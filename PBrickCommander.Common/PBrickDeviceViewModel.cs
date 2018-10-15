using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using Dandy.Lms.PF2;

namespace PBrickCommander
{
    public class PBrickDeviceViewModel : INotifyPropertyChanged
    {
        private readonly Hub hub;
        private readonly Action<Action> invokeOnMainThread;

        public event PropertyChangedEventHandler PropertyChanged;

        public AsyncLabelViewModel Name { get; }

        public bool ButtonState { get; private set; }

        public AsyncLabelViewModel FirmwareVersion { get; }

        public AsyncLabelViewModel HardwareVersion { get; }

        public AsyncLabelViewModel RSSI { get; }

        public AsyncLabelViewModel BatteryPercent { get; }

        public AsyncLabelViewModel Manufacturer { get; }

        public AsyncLabelViewModel BluetoothVersion { get; }

        public ushort Unknown { get; private set; }

        public HubType HubType { get; private set; }

        public byte Channel { get; private set; }

        public AsyncLabelViewModel BluetoothAddress { get; }

        public AsyncLabelViewModel BootloaderBluetoothAddress { get; }

        public PBrickDeviceViewModel(Hub hub, Action<Action> invokeOnMainThread)
        {
            this.hub = hub ?? throw new ArgumentNullException(nameof(hub));
            this.invokeOnMainThread = invokeOnMainThread ?? throw new ArgumentNullException(nameof(invokeOnMainThread));
            Name = new AsyncLabelViewModel(hub.SubscribeNameAsync, hub.SetNameAsync, invokeOnMainThread);

            var buttonObserver = Observer.Create<bool>(x => {
                ButtonState = x;
                OnPropertyChanged(nameof(ButtonState));
            });
            hub.SubscribeButtonStateAsync(buttonObserver);

            FirmwareVersion = new AsyncLabelViewModel(hub.GetFirmwareVersionAsync()
                .ContinueWith(t => t.Result.ToPF2Format()), invokeOnMainThread);
            HardwareVersion = new AsyncLabelViewModel(hub.GetHardwareVersionAsync()
                .ContinueWith(t => t.Result.ToPF2Format()), invokeOnMainThread);

            Task<IDisposable> subscribeRSSIAsync(IObserver<string> observer)
            {
                // have to convert sbyte observer to string observer
                var o = Observer.Create<sbyte>(x => observer.OnNext(x.ToString()),
                    x => observer.OnError(x), () => observer.OnCompleted());
                return hub.SubscribeRSSIAsync(o);
            }

            RSSI = new AsyncLabelViewModel(subscribeRSSIAsync, invokeOnMainThread);

            Task<IDisposable> subscribeBattery(IObserver<string> observer)
            {
                // have to convert byte observer to string observer
                var o = Observer.Create<byte>(x => observer.OnNext(x.ToString()),
                    x => observer.OnError(x), () => observer.OnCompleted());
                return hub.SubscribeBatteryPercentAsync(o);
            }

            BatteryPercent = new AsyncLabelViewModel(subscribeBattery, invokeOnMainThread);

            Manufacturer = new AsyncLabelViewModel(hub.GetManufacturerAsync(), invokeOnMainThread);

            BluetoothVersion = new AsyncLabelViewModel(hub.GetBluetoothFirmwareVersion(), invokeOnMainThread);

            hub.GetUnknownAsync().ContinueWith(t => {
                Unknown = t.Result;
                OnPropertyChanged(nameof(Unknown));
            });

            hub.GetHubTypeAsync().ContinueWith(t => {
                HubType = t.Result;
                OnPropertyChanged(nameof(HubType));
            });

            hub.GetChannelAsync().ContinueWith(t => {
                Channel = t.Result;
                OnPropertyChanged(nameof(Channel));
            });

            BluetoothAddress = new AsyncLabelViewModel(hub.GetBluetoothAddressAsync()
                .ContinueWith(t => t.Result.ToString()), invokeOnMainThread);

            BootloaderBluetoothAddress = new AsyncLabelViewModel(hub.GetBootloaderBluetoothAddressAsync()
                .ContinueWith(t => t.Result.ToString()), invokeOnMainThread);
        }

        private void OnPropertyChanged(string propertyName)
        {
            invokeOnMainThread(() =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)));
        }
    }
}

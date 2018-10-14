using System;
using System.ComponentModel;
using Dandy.Lms.PF2;

namespace PBrickCommander
{
    public class PBrickDeviceViewModel : INotifyPropertyChanged
    {
        private readonly Hub hub;
        private readonly Action<Action> invokeOnMainThread;

        public event PropertyChangedEventHandler PropertyChanged;

        public AsyncLabelViewModel Name { get; }

        public AsyncLabelViewModel FirmwareVersion { get; }

        public PBrickDeviceViewModel(Hub hub, Action<Action> invokeOnMainThread)
        {
            this.hub = hub ?? throw new ArgumentNullException(nameof(hub));
            this.invokeOnMainThread = invokeOnMainThread ?? throw new ArgumentNullException(nameof(invokeOnMainThread));
            Name = new AsyncLabelViewModel(hub.SubscribeNameAsync, hub.SetNameAsync, invokeOnMainThread);
            FirmwareVersion = new AsyncLabelViewModel(hub.GetFirmwareVersionAsync()
                .ContinueWith<string>(t => t.Result.ToPF2Format()), invokeOnMainThread);
        }

        private void Connection_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName) {
                case nameof(BLEConnection.Name):
                    invokeOnMainThread(() => 
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name))));
                    break;
            }
        }
    }
}

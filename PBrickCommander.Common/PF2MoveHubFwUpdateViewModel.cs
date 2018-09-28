using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Dandy.Devices.BluetoothLE;

namespace PBrickCommander
{
    public sealed class PF2MoveHubFwUpdateViewModel
    {
        private readonly ReadOnlyMemory<byte> firmware;
        private readonly Action close;
        private readonly Action<Action> invokeOnUIThread;
        private int busyCount;
        private readonly AdvertisementWatcher watcher;

        public BindingList<PF2MoveHubFwUpdateDeviceViewModel> Devices { get; }

        public PF2MoveHubFwUpdateViewModel(ReadOnlyMemory<byte> firmware, Action close, Action<Action> invokeOnUIThread)
        {
            this.firmware = firmware;
            this.close = close ?? throw new ArgumentNullException(nameof(close));
            this.invokeOnUIThread = invokeOnUIThread ?? throw new ArgumentNullException(nameof(invokeOnUIThread));
            Devices = new BindingList<PF2MoveHubFwUpdateDeviceViewModel>();
            watcher = new AdvertisementWatcher(new Guid("00001625-1212-efde-1623-785feabcd123"));
            watcher.Received += Watche_Received;
            watcher.Stopped += Watcher_Stopped;
        }
        
        private void Watche_Received(object sender, AdvertisementReceivedEventArgs e)
        {
            invokeOnUIThread(() => {
                var match = Devices.SingleOrDefault(x => x.BDAddr == e.Address.ToString());
                if (match == null) {
                    Devices.Add(new PF2MoveHubFwUpdateDeviceViewModel(e));
                }
                else {
                    match.Update(e);
                }
            });
        }

        private void Watcher_Stopped(object sender, AdvertisementWatcherStoppedEventArgs e)
        {
            invokeOnUIThread(() => {
                // TODO: what to here? for example if bluetooth is turned off
            });
        }

        public void Start()
        {
            watcher.Start();
        }

        public void Stop()
        {
            watcher.Stop();
        }

        public void Close()
        {
            if (busyCount > 0) {
                throw new InvalidOperationException("Devices are busy");
            }
            close();
        }
    }
}

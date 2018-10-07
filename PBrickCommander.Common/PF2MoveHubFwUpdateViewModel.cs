using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Dandy.Devices.BluetoothLE;
using Dandy.Lms.PF2.FirmwareUpdate;

namespace PBrickCommander
{
    public sealed class PF2MoveHubFwUpdateViewModel
    {
        private readonly ReadOnlyMemory<byte> firmware;
        private readonly Action close;
        private readonly Action<Action> invokeOnUIThread;
        private int busyCount;
        private readonly HubWatcher watcher;

        public BindingList<PF2MoveHubFwUpdateDeviceViewModel> Devices { get; }

        public PF2MoveHubFwUpdateViewModel(ReadOnlyMemory<byte> firmware, Action close, Action<Action> invokeOnUIThread)
        {
            this.firmware = firmware;
            this.close = close ?? throw new ArgumentNullException(nameof(close));
            this.invokeOnUIThread = invokeOnUIThread ?? throw new ArgumentNullException(nameof(invokeOnUIThread));
            Devices = new BindingList<PF2MoveHubFwUpdateDeviceViewModel>();
            // TODO: also detect official firmware and offer to reboot
            watcher = new HubWatcher(HubType.MoveHub);
            watcher.HubConnected += Watcher_HubConnected;
        }
        
        private void Watcher_HubConnected(object sender, Hub hub)
        {
            invokeOnUIThread(() => {
                var match = Devices.SingleOrDefault(x => x.BDAddr == hub.Id);
                if (match == null) {
                    Devices.Add(new PF2MoveHubFwUpdateDeviceViewModel(hub, null));
                }
                else {
                    match.Update(hub);
                }
            });
        }

        public void Start()
        {
            watcher.StartScan();
        }

        public void Stop()
        {
            watcher.StopScan();
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

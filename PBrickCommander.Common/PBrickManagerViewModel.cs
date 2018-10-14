using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Dandy.Lms.PF2;

namespace PBrickCommander
{
    public sealed class PBrickManagerViewModel
    {
        private readonly HubWatcher watcher;
        private readonly Action<Action> invokeOnMainThread;

        public BindingList<PBrickDeviceViewModel> Devices { get; }

        public PBrickManagerViewModel(Action<Action> invokeOnMainThread)
        {
            this.invokeOnMainThread = invokeOnMainThread ?? throw new ArgumentNullException(nameof(invokeOnMainThread));
            Devices = new BindingList<PBrickDeviceViewModel>();
            watcher = new HubWatcher();
            watcher.HubConnected += Watcher_HubConnected;
        }

        private void Watcher_HubConnected(object sender, Hub hub)
        {
            invokeOnMainThread(() => Devices.Add(new PBrickDeviceViewModel(hub, invokeOnMainThread)));
        }

        public void StartScan()
        {
            watcher.Start();
        }
    }
}

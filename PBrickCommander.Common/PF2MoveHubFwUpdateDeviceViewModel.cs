using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Dandy.Devices.BluetoothLE;
using Dandy.Lms.PF2;
using Dandy.Lms.PF2.FirmwareUpdate;
using Microsoft.Extensions.Logging;

namespace PBrickCommander
{
    public sealed class PF2MoveHubFwUpdateDeviceViewModel : INotifyPropertyChanged
    {
        private Hub hub;
        private readonly ILogger logger;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; private set; }
        public string BDAddr => hub.Id;
        public string FwVersion { get; private set; }
        
        internal PF2MoveHubFwUpdateDeviceViewModel(Hub hub, ILogger logger)
        {
            this.hub = hub ?? throw new ArgumentNullException(nameof(hub));
            this.logger = logger;
            Name = hub.Name;
            // TODO: set a property to indicate error if InitAsync fails
            InitAsync().ContinueWith(t => {
                if (t.IsFaulted) {
                    logger.LogDebug(t.Exception, "Unhandled exception in {0}", nameof(PF2MoveHubFwUpdateDeviceViewModel));
                }
            });
        }

        async Task InitAsync()
        {
            var (_, fwVersion) = await hub.GetDeviceInfoAsync();
            FwVersion = fwVersion.ToPF2Format();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FwVersion)));
        }

        internal void Update(Hub hub)
        {
            this.hub = hub;
        }
    }
}

using System;
using System.ComponentModel;
using Dandy.Devices.BluetoothLE;


namespace PBrickCommander
{
    public sealed class PF2MoveHubFwUpdateDeviceViewModel : INotifyPropertyChanged
    {
        private AdvertisementReceivedEventArgs ad;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name => ad.Advertisement.LocalName;
        public string BDAddr => ad.Address.ToString();
        public string FwVersion { get; }
        
        internal PF2MoveHubFwUpdateDeviceViewModel(AdvertisementReceivedEventArgs ad)
        {
            this.ad = ad ?? throw new System.ArgumentNullException(nameof(ad));
        }

        internal void Update(AdvertisementReceivedEventArgs e)
        {
            ad = e;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
        }
    }
}

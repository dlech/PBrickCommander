using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace PBrickCommander
{
    public sealed class NxtFwUpdateViewModel : INotifyPropertyChanged
    {
        private readonly Action close;
        private readonly ObservableCollection<NxtFwUpdateDeviceViewModel> devices;
        private readonly ReadOnlyMemory<byte> data;

        public bool CanClose { get; private set; } = true;

        public ReadOnlyObservableCollection<NxtFwUpdateDeviceViewModel> Devices { get; }
        
        public NxtFwUpdateViewModel(ReadOnlyMemory<byte> data, Action close)
        {
            this.data = data;
            this.close = close ?? throw new ArgumentNullException(nameof(close));
            devices = new ObservableCollection<NxtFwUpdateDeviceViewModel>();
            Devices = new ReadOnlyObservableCollection<NxtFwUpdateDeviceViewModel>(devices);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Start()
        {

        }

        public void Stop()
        {

        }

        void Close()
        {
            if (!CanClose) {
                throw new InvalidOperationException();
            }
            close();
        }
    }
}

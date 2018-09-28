using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBrickCommander.WinForms
{
    public partial class PF2MoveHubFwUpdateForm : Form
    {
        private readonly PF2MoveHubFwUpdateViewModel viewModel;

        public PF2MoveHubFwUpdateForm(ReadOnlyMemory<byte> firmware)
        {
            InitializeComponent();
            viewModel = new PF2MoveHubFwUpdateViewModel(firmware, Close, InvokeOnUIThread);
        }

        void InvokeOnUIThread(Action action)
        {
            if (InvokeRequired) {
                Invoke(action);
            }
            else {
                action();
            }
        }

        private void PF2MoveHubFwUpdateForm_Load(object sender, EventArgs e)
        {
            pF2MoveHubFwUpdateDeviceViewModelBindingSource.DataSource = viewModel.Devices;
            viewModel.Start();
        }
    }
}

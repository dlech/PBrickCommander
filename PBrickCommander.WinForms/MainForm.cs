using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBrickCommander.WinForms
{
    public partial class mainForm : Form
    {
        private PF2MoveHubFwUpdateForm pf2MoveHubUpdateForm;

        public mainForm()
        {
            InitializeComponent();
        }

        private void boostFwUpdateButton_Click(object sender, EventArgs e)
        {
            // if there is already a window open, bring it to the foreground
            if (pf2MoveHubUpdateForm != null) {
                pf2MoveHubUpdateForm.Activate();
                return;
            }

            // TODO: create dialog that allows fetching firmware from online sources
            // in addition to opening a file
            var dialog = new OpenFileDialog {
                // TODO: downloads folder would be better starting place
                // https://stackoverflow.com/questions/10667012/getting-downloads-folder-in-c#21953690
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            };

            var result = dialog.ShowDialog(this);
            if (result != DialogResult.OK) {
                return;
            }

            // TODO: need to catch/handle exceptions here
            var firmware = File.ReadAllBytes(dialog.FileName);
            // TODO: need to validate firmware file somehow
            pf2MoveHubUpdateForm = new PF2MoveHubFwUpdateForm(firmware);
            pf2MoveHubUpdateForm.FormClosed += (s, a) => pf2MoveHubUpdateForm = null;
            pf2MoveHubUpdateForm.Show();
        }
    }
}

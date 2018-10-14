using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBrickCommander.WinForms
{
    public class AsyncTextBoxColumn : DataGridViewColumn
    {
        public AsyncTextBoxColumn() : base(new AsyncTextBoxCell())
        {
        }

        public override DataGridViewCell CellTemplate {
            get => base.CellTemplate;
            // just ensuring we get the expected cell type
            set => base.CellTemplate = (AsyncTextBoxCell)value;
        }
    }
}

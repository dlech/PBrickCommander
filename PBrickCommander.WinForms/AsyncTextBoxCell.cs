using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PBrickCommander.WinForms
{
    public class AsyncTextBoxCell : DataGridViewTextBoxCell
    {
        public override Type ValueType => typeof(AsyncLabelViewModel);
        
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            return (value as AsyncLabelViewModel)?.Text;
        }
    }
}

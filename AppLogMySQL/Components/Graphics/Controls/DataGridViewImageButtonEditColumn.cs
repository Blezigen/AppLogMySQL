using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AppLogMySQL.Components.Graphics.Controls
{
    public class DataGridViewImageButtonEditColumn : DataGridViewButtonColumn
    {
        public class DataGridViewImageButtonEditCell : DataGridViewImageButtonCell
        {
            public override void LoadImages()
            {
                _buttonImageNormal = AppLogMySQL.ResourceApplication.Edit;

                _buttonImageDisabled = AppLogMySQL.ResourceApplication.Edit;
                _buttonImagePressed = AppLogMySQL.ResourceApplication.Edit;
                _buttonImageHot = AppLogMySQL.ResourceApplication.Edit;
                this.ButtonState = PushButtonState.Normal;
            }
        }

        public DataGridViewImageButtonEditColumn()
        {
            this.CellTemplate = new DataGridViewImageButtonEditCell();
            this.Width = 23;
            this.Resizable = DataGridViewTriState.False;
            this.Name = "EditButtons";
            this.HeaderText = "";
            this.ReadOnly = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AppLogMySQL.Components.Graphics.Controls
{
    public class DataGridViewImageButtonDeleteColumn : DataGridViewButtonColumn
    {
        public class DataGridViewImageButtonDeleteCell : DataGridViewImageButtonCell
        {
            public override void LoadImages()
            {
                _buttonImageNormal = AppLogMySQL.ResourceApplication.Delete;

                _buttonImageDisabled = AppLogMySQL.ResourceApplication.Delete;
                _buttonImagePressed = AppLogMySQL.ResourceApplication.Delete;
                _buttonImageHot = AppLogMySQL.ResourceApplication.Delete;


            }
        }
        public DataGridViewImageButtonDeleteColumn()
        {
            this.CellTemplate = new DataGridViewImageButtonDeleteCell();
            this.Width = 23;
            this.Resizable = DataGridViewTriState.False;
            this.Name = "DeleteButtons";
            this.HeaderText = "";
            this.ReadOnly = false;

        }
    }
}

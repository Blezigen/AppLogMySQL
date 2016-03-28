using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Resources;

namespace AppLogMySQL.Gui.Components
{
    [System.ComponentModel.DesignerCategory("Code")]
    [Designer(typeof(CustomPanelDesigner))]
    public class CustomPanel : Panel
    {
        private Color _borderColor = Color.Transparent;

        [Browsable(true)]
        public Color BorderColor
        {
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
            get{ return _borderColor; }
        }

        public CustomPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);

            Pen n = new Pen(_borderColor);
            n.Color = _borderColor;
            e.Graphics.DrawRectangle(n, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
        }

    }
    internal class CustomPanelDesigner : ControlDesigner
    {
        private CustomPanel control;

        protected override void OnMouseDragBegin(int x, int y)
        {
            base.OnMouseDragBegin(x, y);
            control = (CustomPanel)(this.Control);
        }
        protected override void OnMouseLeave()
        {
            base.OnMouseLeave();
            control = (CustomPanel)(this.Control);
        } 
    }
}

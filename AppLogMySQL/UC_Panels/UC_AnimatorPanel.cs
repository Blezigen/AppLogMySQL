using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppLogMySQL.UC_Panels
{
    public partial class UC_AnimatorPanel : UserControl
    {
        private List<System.Windows.Forms.UserControl> Panels;
        //System.Resources.ResourceManager r;
        int currentPanel;
        int alphaPanelTop = 0;
        public void NextPanel(UserControl p)
        {
            currentPanel++;
            Panels.Add(p);
            p.Dock = DockStyle.Fill;
            PanelPosTop.Controls.Clear();
            Panels[currentPanel].Parent = PanelPosTop;
        }
        public void PrevPanel()
        {
            if (currentPanel > -1){
                PanelPosTop.Controls.Clear();
                Panels.RemoveAt(currentPanel);
                currentPanel--;
                if (currentPanel > -1)
                {
                    Panels[currentPanel].Parent = PanelPosTop;
                }
            }
            else
            {
                PanelPosTop.Controls.Clear();
            }
        }
        public UC_AnimatorPanel()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Panels = new List<UserControl>();
            alphaPanelTop = 0;
            PanelPosTop.Width = this.Width;
            PanelPosTop.Location = new Point(0, 0);
            PanelPosTop.BackColor = Color.FromArgb(alphaPanelTop, 255, 255, 255);
            currentPanel = -1;

            /*Panel p = new Panel();
            p.Name = "P1";
            p.BackColor = Color.Red;
            p.Dock = System.Windows.Forms.DockStyle.Fill;
            p.Parent = PanelPosBottom;

            Panel p2 = new Panel();
            p2.Name = "P2";
            p2.BackColor = Color.Blue;
            p2.Dock = System.Windows.Forms.DockStyle.Fill;
            p2.Parent = PanelPosTop;

            Panels.Add(p);
            Panels.Add(p2);

            Panels[0].Parent = PanelPosBottom;
            Panels[1].Parent = PanelPosTop;*/

        }
        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.PanelPosTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelPosTop
            // 
            this.PanelPosTop.BackColor = System.Drawing.SystemColors.Control;
            this.PanelPosTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPosTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPosTop.Location = new System.Drawing.Point(0, 0);
            this.PanelPosTop.Name = "PanelPosTop";
            this.PanelPosTop.Size = new System.Drawing.Size(424, 395);
            this.PanelPosTop.TabIndex = 2;
            this.PanelPosTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPosTop_Paint);
            // 
            // UC_AnimatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelPosTop);
            this.Name = "UC_AnimatorPanel";
            this.Size = new System.Drawing.Size(424, 395);
            this.SizeChanged += new System.EventHandler(this.AnimatorPanel_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPosTop;

        private void AnimatorPanel_SizeChanged(object sender, EventArgs e)
        {
            PanelPosTop.Top = 0;
            PanelPosTop.Height = this.Height;
        }

        private void PanelPosTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

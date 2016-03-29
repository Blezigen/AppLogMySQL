using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace AppLogMySQL
{
    public partial class MainForm : Form
    {
        public MySqlConnection connection;

        private bool isFullScreen() {
            if (Screen.PrimaryScreen.Bounds.Width == this.Width && Screen.PrimaryScreen.Bounds.Height == this.Height)
            {
                if (WindowState != FormWindowState.Minimized)
                    return true;
            }
            return false;
        }


        private void toogleToFullScreen()
        {
            WindowState = FormWindowState.Maximized;
        }

        private void toogleToMinimaze()
        {
            WindowState = FormWindowState.Minimized;

        }

        private void toogleBackOutFullScreen()
        {
            WindowState = FormWindowState.Normal;
        }

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DataCollection._NextForm = ap.NextPanel;
            DataCollection._PrevForm = ap.PrevPanel;
            DataCollection.DataConnection.initialiseConnection();
            UC_Panels.UC_LoginPanel p = new UC_Panels.UC_LoginPanel();
            DataCollection._NextForm(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataCollection.mainFormer = this;
            labelTitle.Font = new Font("Proxima Nova", 9, FontStyle.Regular);
            labelTitle.ForeColor = Color.FromArgb(243,237,210);
            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                Invalidate();
            };
            toogleBackOutFullScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!isFullScreen())
                toogleToFullScreen();
            else
                toogleBackOutFullScreen();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (isFullScreen())
                SizeChanger.Image = ResourceApplication.Normalizate;
            else 
                SizeChanger.Image = ResourceApplication.Maximaze;
            base.OnPaint(e);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            toogleToMinimaze();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //ap.PrevPanel();
            Close();
        }

        private void ap_Load(object sender, EventArgs e)
        {

        }


    }
}

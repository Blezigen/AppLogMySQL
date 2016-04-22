using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppLogMySQL.Components.Graphics.Window
{
    public partial class Window_Specialization : Form
    {
        public Window_Specialization()
        {
            #if (DEBUG)
                Console.WriteLine("Инициализация");
            #endif
            InitializeComponent();
            this.labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            this.labelTitle.ForeColor = Color.FromArgb(243, 237, 210);
            InitializeFunction();
            InitializeVars();

        }

        private void InitializeFunction()
        {
            this.Load += new System.EventHandler(this.Window_Load);
            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                Invalidate();
            };
            this.CloseButton.MouseUp += delegate
            {
                this.Close();
            };
        }

        private void InitializeVars()
        {

        }

        private void FillControls()
        {
            #if (DEBUG)
                Console.WriteLine("Заполнение элементов");
            #endif
        }
        private void Window_Load(object sender, EventArgs e)
        {
            this.FillControls();
        }
    }
}

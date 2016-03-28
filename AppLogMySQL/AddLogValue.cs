using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppLogMySQL
{
    public partial class AddLogValue : Form
    {
        public AddLogValue()
        {
            InitializeComponent();
        }

        private void AddLogValue_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
           /* if (e.KeyCode == Keys.)
            {
                base.OnKeyDown(e);
            }
            if (e.KeyCode == Keys.Right)
            {
                base.OnKeyDown(e);
            }
            if (e.KeyCode == Keys.Up)
            {
                base.OnKeyDown(e);
            }
            if (e.KeyCode == Keys.Up)
            {
                base.OnKeyDown(e);
            }
            if (e.KeyCode == Keys.Up)
            {
                base.OnKeyDown(e);
            }*/
        }

        private void AddLogValue_Load(object sender, EventArgs e)
        {

        }
    }
}

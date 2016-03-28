using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppLogMySQL.ControllPanel.UserControls
{
    public partial class CP_SelectedLog : UserControl
    {
        public CP_SelectedLog()
        {
            InitializeComponent();
        }

        private void CP_SelectedLog_Load(object sender, EventArgs e)
        {

        }

        public void changeText() {
            //buttonGroup.Text;
            //buttonDisciplina;
            //comboBoxTypeValues.s
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex){
                case 0: DataCollection.DataLogController.month = 9; DataCollection.DataLogController.year = 2015; break;
                case 1: DataCollection.DataLogController.month = 10; DataCollection.DataLogController.year = 2015; break;
                case 2: DataCollection.DataLogController.month = 11; DataCollection.DataLogController.year = 2015; break;
                case 3: DataCollection.DataLogController.month = 12; DataCollection.DataLogController.year = 2015; break;
                case 4: DataCollection.DataLogController.month = 1; DataCollection.DataLogController.year = 2016; break;
                case 5: DataCollection.DataLogController.month = 2; DataCollection.DataLogController.year = 2016; break;
                case 6: DataCollection.DataLogController.month = 3; DataCollection.DataLogController.year = 2016; break;
                case 7: DataCollection.DataLogController.month = 4; DataCollection.DataLogController.year = 2016; break;
                case 8: DataCollection.DataLogController.month = 5; DataCollection.DataLogController.year = 2016; break;
                case 9: DataCollection.DataLogController.month = 6; DataCollection.DataLogController.year = 2016; break;
                case 10: DataCollection.DataLogController.month = 7; DataCollection.DataLogController.year = 2016; break;
            }
            //MessageBox.Show(DataCollection.LogControllData.month.ToString());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void comboBoxTypeValues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

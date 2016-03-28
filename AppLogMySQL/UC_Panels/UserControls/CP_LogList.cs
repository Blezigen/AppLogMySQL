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
    public partial class CP_LogList : UserControl
    {
        public DataTable d;
        public CP_LogList()
        {
            InitializeComponent();
        }

        private void CP_LogList_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void dataGridViewLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LogDock.Visible = true;//id_discipline
            DataCollection.querySelectGADData(Int32.Parse(d.Rows[dataGridViewLogs.CurrentRow.Index]["id_group"].ToString()), Int32.Parse(d.Rows[dataGridViewLogs.CurrentRow.Index]["id_discipline"].ToString()));
            LogDock.Grid.DisplayDataInGrid(DataCollection.queryGetLogData());
        }

        private void dataGridViewLogs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}

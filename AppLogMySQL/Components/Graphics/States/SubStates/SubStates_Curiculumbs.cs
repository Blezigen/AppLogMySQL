using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AppLogMySQL.Components.Graphics.States.SubStates
{
    public partial class SubStates_Curiculumbs : UserControl
    {
        Dictionary<string, object> groups;

        public SubStates_Curiculumbs()
        {
            InitializeComponent();
        }

        private void fillContainer(DataGridView d, IDictionary rowa)
        {
            foreach (DictionaryEntry vals in rowa)
            {
                d.Rows[int.Parse(vals.Key.ToString())].Cells[1].Value = vals.Value.ToString();
            }
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySql.SelectQuerys.SQuery_Set_Group set_group_query = new MySql.SelectQuerys.SQuery_Set_Group(comboBoxGroups.SelectedIndex + 1);

            MySql.SelectQuerys.SQuery_GetAffordableDisciplineByGroup query = new MySql.SelectQuerys.SQuery_GetAffordableDisciplineByGroup();
            set_group_query.run(Data.DataManager._connection);
            query.run(Data.DataManager._connection);
            Dictionary<string, object> da = query.getFormatData();

            
        }

        private void SubStates_Schedules_Load(object sender, EventArgs e)
        {
            MySql.SelectQuerys.SQuery_GetAllGroups query = new MySql.SelectQuerys.SQuery_GetAllGroups();
            query.run(Data.DataManager._connection);
            groups = query.getFormatData();
            foreach (KeyValuePair<string, object> val in groups)
            {
                comboBoxGroups.Items.Add(val.Value.ToString());
            }
            //ClearContainer(SchedulesDayData1);
            this.Width = Parent.Width;
            this.Height = Parent.Height;
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AppLogMySQL.Components.Data.DataManager.substate_states.state_Change("UserProfile");
        }
    }
}

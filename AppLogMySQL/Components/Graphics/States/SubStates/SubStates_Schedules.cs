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
    public partial class SubStates_Schedules : UserControl
    {
        Dictionary<string, object> groups; 

        public SubStates_Schedules()
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

        private void ClearContainer(DataGridView d)
        {
            d.Rows.Clear();
            for (int i = 1; i <= 7; i++)
                d.Rows.Add(i.ToString(), string.Empty);

        }
        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySql.SelectQuerys.SQuery_SetGroup set_group_query = new MySql.SelectQuerys.SQuery_SetGroup();
            MySql.SelectQuerys.SQuery_GetSchedules query = new MySql.SelectQuerys.SQuery_GetSchedules();
            set_group_query.SelectedGroup = (comboBoxGroups.SelectedIndex+1).ToString();
            set_group_query.run(Data.DataManager._connection);
            query.run(Data.DataManager._connection);
            Dictionary<string, object> da = query.getFormatData();

            ClearContainer(SchedulesDayData1);
            ClearContainer(SchedulesDayData2);
            ClearContainer(SchedulesDayData3);
            ClearContainer(SchedulesDayData4);
            ClearContainer(SchedulesDayData5);
            ClearContainer(SchedulesDayData6);
            foreach (KeyValuePair<string, object> val in da)
            {
                switch (val.Key)
                {
                    case "1": { fillContainer(SchedulesDayData1, (IDictionary)val.Value); break; }
                    case "2": { fillContainer(SchedulesDayData2, (IDictionary)val.Value); break; }
                    case "3": { fillContainer(SchedulesDayData3, (IDictionary)val.Value); break; }
                    case "4": { fillContainer(SchedulesDayData4, (IDictionary)val.Value); break; }
                    case "5": { fillContainer(SchedulesDayData5, (IDictionary)val.Value); break; }
                    case "6": { fillContainer(SchedulesDayData6, (IDictionary)val.Value); break; }
                }
              
            }
          
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
            ClearContainer(SchedulesDayData1);
            ClearContainer(SchedulesDayData2);
            ClearContainer(SchedulesDayData3);
            ClearContainer(SchedulesDayData4);
            ClearContainer(SchedulesDayData5);
            ClearContainer(SchedulesDayData6);
        }
    }
}

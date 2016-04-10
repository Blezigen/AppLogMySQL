using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AppLogMySQL.Components.MySql.SelectQuerys;
using AppLogMySQL.Components.MySql.SetQuerys;


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
                d.Rows[int.Parse(vals.Key.ToString())-1].Cells[1].Value = vals.Value.ToString();
            }
        }

        private void ClearContainer(DataGridView d)
        {
            d.Rows.Clear();
            for (int i = 1; i <= 7; i++)
                d.Rows.Add(i.ToString(), string.Empty);

        }
        void fill() {
            SQuery_Set_Group set_group_query = new SQuery_Set_Group(comboBoxGroups.SelectedIndex + 1);
            SQuery_GetSchedules query = new SQuery_GetSchedules();
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
        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill();
          
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
            this.Width = Parent.Width;
            this.Height = Parent.Height;
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AppLogMySQL.Components.Data.DataManager.substate_states.state_Change("UserProfile");
        }

        void showEdit(int weekday)
        {
            Windows.EditSchedulesDateOfWeek ev = new Windows.EditSchedulesDateOfWeek();
            ev.group = comboBoxGroups.SelectedIndex + 1;
            ev.sch_day = weekday;
            ev.ShowDialog();
        }

        private void EditButton1_Click(object sender, EventArgs e)
        {
            showEdit(1);
            fill();
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {
            showEdit(2);
            fill();
        }

        private void EditButton3_Click(object sender, EventArgs e)
        {
            showEdit(3);
            fill();
        }

        private void EditButton4_Click(object sender, EventArgs e)
        {
            showEdit(4);
            fill();
        }

        private void EditButton5_Click(object sender, EventArgs e)
        {
            showEdit(5);
            fill();
        }

        private void EditButton6_Click(object sender, EventArgs e)
        {
            showEdit(6);
            fill();
        }
    }
}

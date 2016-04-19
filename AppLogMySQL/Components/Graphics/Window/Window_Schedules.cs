using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AppLogMySQL.Components.MySql.SelectQuerys;
using AppLogMySQL.Components.MySql.SetQuerys;

namespace AppLogMySQL.Components.Graphics.Window
{
    public partial class Window_Schedules : Form
    {
        Dictionary<string, object> groups;
        void REVERT(bool V) {
            SchedulesDayData1.Enabled = V;
            EditButton1.Enabled = V;
            SchedulesDayData2.Enabled = V;
            EditButton2.Enabled = V;
            SchedulesDayData3.Enabled = V;
            EditButton3.Enabled = V;
            SchedulesDayData4.Enabled = V;
            EditButton4.Enabled = V;
            SchedulesDayData5.Enabled = V;
            EditButton5.Enabled = V;
            SchedulesDayData6.Enabled = V;
            EditButton6.Enabled = V;
        }
        public Window_Schedules()
        {
            InitializeComponent();

            REVERT(false);

            labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            labelTitle.ForeColor = Color.FromArgb(243, 237, 210);

            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                Invalidate();
            };
        }

        private void fillContainer(DataGridView d, IDictionary rowa)
        {
            foreach (DictionaryEntry vals in rowa)
            {
                d.Rows[int.Parse(vals.Key.ToString()) - 1].Cells[1].Value = vals.Value.ToString();
            }
        }

        private void ClearContainer(DataGridView d)
        {
            d.Rows.Clear();
            for (int i = 1; i <= 7; i++)
                d.Rows.Add(i.ToString(), string.Empty);

        }
        void fill()
        {
            SQuery_Set_WeekDay query_wd = new SQuery_Set_WeekDay(-1);
            SQuery_Set_Group set_group_query = new SQuery_Set_Group(comboBoxGroups.SelectedIndex + 1);
            SQuery_Get_Schedules query = new SQuery_Get_Schedules();
            query_wd.run(Data.DataManager._connection);
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
            REVERT(true);
            fill();

        }

        void showEdit(int weekday)
        {
            Windows.Dialog_Add_Edit_Schedules_Day_Week ev = new Windows.Dialog_Add_Edit_Schedules_Day_Week();
            ev.group = comboBoxGroups.SelectedIndex + 1;
            ev.weekday = weekday;
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

        private void Window_Schedules_Load(object sender, EventArgs e)
        {
            MySql.SelectQuerys.SQuery_Get_Groups_All query = new MySql.SelectQuerys.SQuery_Get_Groups_All();
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

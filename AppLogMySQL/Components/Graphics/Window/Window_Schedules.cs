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
using AppLogMySQL.Components.Graphics.Dialog;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Window
{
    public partial class Window_Schedules : Form
    {
        SQuery_Set_WeekDay query_set_weekday;
        SQuery_Get_Schedules query_get_schedules;

        int group;

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

        public bool Show(int _id)
        {
            group = _id;
            REVERT(true);
            this.ShowDialog();
            return true;
        }

        public Window_Schedules()
        {
            InitializeComponent();

            this.Text = "Редактирование расписания";
            this.Icon = global::AppLogMySQL.ResourceApplication.AppIco;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeFunction();
            InitializeVars();
        }

        void InitializeFunction()
        {
            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                Invalidate();
            };
        }

        void InitializeVars()
        {
            REVERT(true);
            labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            labelTitle.ForeColor = Color.FromArgb(243, 237, 210);
            this.query_set_weekday = new SQuery_Set_WeekDay(-1);
            this.query_get_schedules = new SQuery_Get_Schedules();
            FillControls();
        }

        void FillControls()
        {
            this.query_set_weekday.run(DataManager._connection);
            this.query_get_schedules.run(DataManager._connection);

            DataView weekday1 = new DataView(query_get_schedules.dataset.Tables[0]);
            weekday1.RowFilter = "day = 1";
            weekday1.Sort = "para";
            DataView weekday2 = new DataView(query_get_schedules.dataset.Tables[0]);
            weekday2.RowFilter = "day = 2";
            weekday2.Sort = "para";
            DataView weekday3 = new DataView(query_get_schedules.dataset.Tables[0]);
            weekday3.RowFilter = "day = 3";
            weekday3.Sort = "para";
            DataView weekday4 = new DataView(query_get_schedules.dataset.Tables[0]);
            weekday4.RowFilter = "day = 4";
            weekday4.Sort = "para";
            DataView weekday5 = new DataView(query_get_schedules.dataset.Tables[0]);
            weekday5.RowFilter = "day = 5";
            weekday5.Sort = "para";
            DataView weekday6 = new DataView(query_get_schedules.dataset.Tables[0]);
            weekday6.RowFilter = "day = 6";
            weekday6.Sort = "para";

            this.SchedulesDayData1.AutoGenerateColumns = false;
            this.SchedulesDayData2.AutoGenerateColumns = false;
            this.SchedulesDayData3.AutoGenerateColumns = false;
            this.SchedulesDayData4.AutoGenerateColumns = false;
            this.SchedulesDayData5.AutoGenerateColumns = false;
            this.SchedulesDayData6.AutoGenerateColumns = false;

            this.SchedulesDayData1.DataSource = weekday1;
            this.SchedulesDayData2.DataSource = weekday2;
            this.SchedulesDayData3.DataSource = weekday3;
            this.SchedulesDayData4.DataSource = weekday4;
            this.SchedulesDayData5.DataSource = weekday5;
            this.SchedulesDayData6.DataSource = weekday6;
        }

        void fill()
        {
            SQuery_Set_WeekDay query_wd = new SQuery_Set_WeekDay(-1);
            //SQuery_Set_Group set_group_query = new SQuery_Set_Group(comboBoxGroups.SelectedIndex + 1);
            SQuery_Get_Schedules query = new SQuery_Get_Schedules();
            query_wd.run(Data.DataManager._connection);
            //set_group_query.run(Data.DataManager._connection);
            query.run(Data.DataManager._connection);
            Dictionary<string, object> da = query.getFormatData();

            /*foreach (KeyValuePair<string, object> val in da)
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

            }*/
        }
        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            REVERT(true);
            fill();

        }

        void showEdit(int weekday)
        {
            Dialog_Add_Edit_Schedules_Day_Week ev = new Dialog_Add_Edit_Schedules_Day_Week();
            ev.Group = group;
            ev.Show(weekday);
            FillControls();
        }

        private void EditButton1_Click(object sender, EventArgs e)
        {
            showEdit(1);
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {
            showEdit(2);
        }

        private void EditButton3_Click(object sender, EventArgs e)
        {
            showEdit(3);
        }

        private void EditButton4_Click(object sender, EventArgs e)
        {
            showEdit(4);
        }

        private void EditButton5_Click(object sender, EventArgs e)
        {
            showEdit(5);
        }

        private void EditButton6_Click(object sender, EventArgs e)
        {
            showEdit(6);
        }

        private void Window_Schedules_Load(object sender, EventArgs e)
        {
            MySql.SelectQuerys.SQuery_Get_Groups query = new MySql.SelectQuerys.SQuery_Get_Groups();
            query.run(Data.DataManager._connection);
            //groups = query.getFormatData();
            //foreach (KeyValuePair<string, object> val in groups)
            //{
                //comboBoxGroups.Items.Add(val.Value.ToString());
            //}

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

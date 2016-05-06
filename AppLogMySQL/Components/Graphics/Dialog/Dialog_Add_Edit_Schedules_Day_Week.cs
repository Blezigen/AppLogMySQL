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
using AppLogMySQL.Components.MySql.InsertQuerys;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Dialog
{
    public partial class Dialog_Add_Edit_Schedules_Day_Week : Form
    {
        SQuery_Set_Discipline query_set_d;
        SQuery_Set_WeekDay query_set_weekday;
        SQuery_Set_Para query_set_p;
        SQuery_Set_Teacher query_set_t;
        SQuery_Set_Group query_set_g;

        SQuery_Get_Load_Politic query_get_lp;
        SQuery_Get_Schedules query_get_s;
        SQuery_Get_Affordable_Discipline query_get_a_d;
        SQuery_Get_Teachers query_get_t;
        IQuery_Insert_Schedule iquery_isch;

        private bool showHideOption;

        public int Group
        {
            get { return this.query_set_g.Group; }
            set { this.query_set_g.Group = value; }
        }

        public Dialog_Add_Edit_Schedules_Day_Week()
        {
            this.InitializeComponent();
            this.labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            this.labelTitle.ForeColor = Color.FromArgb(243, 237, 210);
            this.InitializeFunction();
            this.InitializeVars();
        }

        void InitializeVars()
        {
            query_set_d = new SQuery_Set_Discipline(-1);
            query_set_weekday = new SQuery_Set_WeekDay(-1);
            query_set_p = new SQuery_Set_Para(-1);
            query_set_t = new SQuery_Set_Teacher(-1);
            query_set_g = new SQuery_Set_Group(-1);

            query_get_lp = new SQuery_Get_Load_Politic();
            query_get_s = new SQuery_Get_Schedules();
            query_get_a_d = new SQuery_Get_Affordable_Discipline();
            query_get_t = new SQuery_Get_Teachers();
            iquery_isch = new IQuery_Insert_Schedule();
        }

        void InitializeFunction()
        {
            this.Load += new System.EventHandler(this.Window_Load);
            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                this.Invalidate();
            };
            this.CloseButton.MouseUp += delegate
            {
                this.Close();
            };
        }

        void setDataSorce(ComboBox cb, DataTable dt) {
            cb.DataSource = dt;
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
        }
        void FillControls()
        {
            query_set_weekday.run(DataManager._connection);
            query_set_g.run(DataManager._connection);

            query_get_a_d.run(DataManager._connection);
            query_get_s.run(DataManager._connection);
            //query_get_lp.run(DataManager._connection);
            query_get_t.run(DataManager._connection);

            Discipline.DataSource = query_get_a_d.dataset.Tables[0];
            Discipline.DisplayMember = "name";
            Discipline.ValueMember = "id";
            Discipline.DataPropertyName = "id_disp";

            Teachers.DataSource = query_get_t.dataset.Tables[0];
            Teachers.DisplayMember = "name";
            Teachers.ValueMember = "id";

            SchedulesDayData.AutoGenerateColumns = false;
            SchedulesDayData.DataSource = query_get_s.dataset.Tables[0];

        }

        public bool Show(int id_weekday)
        {
            query_set_weekday.Weekday = id_weekday;
            this.FillControls();
            this.ShowDialog();
            return true;
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.query_set_g.Group = Group;
            this.query_set_g.run(DataManager._connection);
            this.query_set_weekday.run(DataManager._connection);

            foreach (DataRow row in ((DataTable)(SchedulesDayData.DataSource)).Rows) {

                this.query_set_d.Discipline = (int)row["id_disp"];
                this.query_set_p.Para = (int)row["para"];
                this.query_set_t.Teacher = (int)row["teacher"];

                this.query_set_t.run(DataManager._connection);
                this.query_set_p.run(DataManager._connection);
                this.query_set_d.run(DataManager._connection);
                this.iquery_isch.run(DataManager._connection);
            
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

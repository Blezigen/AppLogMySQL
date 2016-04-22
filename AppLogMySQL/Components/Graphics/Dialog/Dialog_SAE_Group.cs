using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLogMySQL.Components.MySql.SelectQuerys;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Dialog
{
    public partial class Dialog_SAE_Group : Form
    {
        SQuery_Get_Groups query_get_g;
        SQuery_Set_Group query_set_g;
        SQuery_Set_Specialization query_set_s;
        SQuery_Get_Specializations query_get_s;

        SQuery_Set_Curator query_set_c;
        SQuery_Get_Curator query_get_c;

        SQuery_Get_Students query_get_students;

        SQuery_Set_WeekDay query_set_weekday;
        //SQuery_Set_Group set_group_query = new SQuery_Set_Group(comboBoxGroups.SelectedIndex + 1);
        SQuery_Get_Schedules query_get_schedules;

        private bool fullscreen = false;
        private int id = -1;


        private void InitializeVars()
        {
            this.query_get_g = new SQuery_Get_Groups();
            this.query_get_s = new SQuery_Get_Specializations();
            this.query_get_c = new SQuery_Get_Curator();

            this.query_set_g = new SQuery_Set_Group(-1);
            this.query_set_s = new SQuery_Set_Specialization();
            this.query_set_c = new SQuery_Set_Curator();

            this.query_get_students = new SQuery_Get_Students();

            this.query_set_weekday = new SQuery_Set_WeekDay(-2);
            this.query_get_schedules = new SQuery_Get_Schedules();

            this.query_set_c.Curator = -1;
            this.query_set_s.Specialization = -1;

        }

        public Dialog_SAE_Group()
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

        public bool Show(int _id) {
            this.id = _id;
            this.fullscreen = false;
            this.FillControls();
            this.ShowDialog();
            return true;
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
            this.SizeChanger.MouseUp += delegate
            {
                if (fullscreen)
                {
                    SizeChanger.Image = ResourceApplication.Normalizate;
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    SizeChanger.Image = ResourceApplication.Maximaze;
                    WindowState = FormWindowState.Normal;
                }
                fullscreen = !fullscreen;
            };
            this.CloseButton.MouseUp += delegate
            {
                this.Close();
            };
        }

        private void FillControls()
        {
            #if (DEBUG)
                Console.WriteLine("Заполнение элементов");
            #endif
                this.query_set_g.Group = this.id;

                this.query_set_g.run(DataManager._connection);
                this.query_get_g.run(DataManager._connection);
                this.query_set_s.run(DataManager._connection);
                this.query_get_s.run(DataManager._connection);
                this.query_set_c.run(DataManager._connection);
                this.query_get_c.run(DataManager._connection);
                this.query_get_students.run(DataManager._connection);
                this.query_set_weekday.run(DataManager._connection);
                this.query_get_schedules.run(DataManager._connection);


                this.name_group.Text = query_get_g.dataset.Tables[0].Rows[0]["name"].ToString();

                this.comboBoxSpecialization.DataSource = query_get_s.dataset.Tables[0];
                this.comboBoxSpecialization.DisplayMember = "name";
                this.comboBoxSpecialization.ValueMember = "id";
                this.comboBoxSpecialization.SelectedValue = int.Parse(query_get_g.dataset.Tables[0].Rows[0]["spec"].ToString());


                this.comboBoxTeacher.DataSource = query_get_c.dataset.Tables[0];
                this.comboBoxTeacher.DisplayMember = "name";
                this.comboBoxTeacher.ValueMember = "id";
                this.comboBoxTeacher.SelectedValue = int.Parse(query_get_g.dataset.Tables[0].Rows[0]["curator"].ToString());

                this.dataGridStudents.AutoGenerateColumns = false;
                this.dataGridStudents.DataSource = query_get_students.dataset.Tables[0];

                this.SchedulesDay.AutoGenerateColumns = false;
                this.SchedulesDay.DataSource = query_get_schedules.dataset.Tables[0];
        }
        private void Window_Load(object sender, EventArgs e)
        {
            this.FillControls();
            ///128;
        }

        private void EditButton1_Click(object sender, EventArgs e)
        {
            Window.Window_Schedules win = new Window.Window_Schedules();
            win.Show(1);
            this.FillControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog.Dialog_SAE_Students win = new Dialog_SAE_Students();
            win.Show(1);
            this.FillControls();
        }
    }
}

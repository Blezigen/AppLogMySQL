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
using AppLogMySQL.Components.MySql.InsertQuerys;
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
        SQuery_Get_Schedules query_get_schedules;

        IQuery_Insert_Group iquery_g;

        private bool fullscreen = false;
        private int id = -1;
        private int state = 0;


        void State_read()
        {
            this.Width = 550;
            this.Height = 355;
            buttonOK.Visible = false;
            buttonCancel.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            name_group.Enabled = false;
            comboBoxSpecialization.Enabled = false;
            comboBoxTeacher.Enabled = false;
            buttonEditStudent.Enabled = false;
            SizeChanger.Visible = true;
        }
        void State_edit()
        {
            this.Width = 550;
            this.Height = 375;
            buttonOK.Visible = true;
            buttonCancel.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            name_group.Enabled = true;
            comboBoxSpecialization.Enabled = true;
            comboBoxTeacher.Enabled = true;
            buttonEditStudent.Enabled = true;
            SizeChanger.Visible = true;

            buttonOK.Text = "Изменить";
        }
        void State_add()
        {
            SizeChanger.Visible = false;
            this.Width = 550;
            this.Height = 145;
            buttonOK.Visible = true;
            buttonOK.Text = "OK";
            buttonCancel.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

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

            this.dataGridStudents.AutoGenerateColumns = false;
            this.SchedulesDay.AutoGenerateColumns = false;

            this.iquery_g = new IQuery_Insert_Group();
        }

        public Dialog_SAE_Group()
        {
            #if (DEBUG)
                Console.WriteLine("Инициализация");
            #endif
            this.InitializeComponent();

            this.Text = "Изменение группы";
            this.Icon = global::AppLogMySQL.ResourceApplication.AppIco;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            this.labelTitle.ForeColor = Color.FromArgb(243, 237, 210);
            this.InitializeFunction();
            this.InitializeVars();

        }

        public bool Show(int _id=-1,int type = 0) {
            this.id = _id;
            this.fullscreen = false;
            switch (type)
            {
                case 0: State_read(); break;
                case 1: State_edit(); break;
                case 2: State_add(); break;
                default: return false;
            }
            this.state = type;
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
                this.Invalidate();
            };
            this.SizeChanger.MouseUp += delegate
            {
                if (!this.fullscreen)
                {
                    this.SizeChanger.Image = ResourceApplication.Normalizate;
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.SizeChanger.Image = ResourceApplication.Maximaze;
                    this.WindowState = FormWindowState.Normal;
                }
                this.fullscreen = !this.fullscreen;
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

                this.comboBoxSpecialization.DataSource = this.query_get_s.dataset.Tables[0];
                this.comboBoxSpecialization.DisplayMember = "name";
                this.comboBoxSpecialization.ValueMember = "id";

                this.comboBoxTeacher.DataSource = this.query_get_c.dataset.Tables[0];
                this.comboBoxTeacher.DisplayMember = "name";
                this.comboBoxTeacher.ValueMember = "id";

                if (state != 2)
                {
                    this.query_get_students.run(DataManager._connection);
                    this.query_set_weekday.run(DataManager._connection);
                    this.query_get_schedules.run(DataManager._connection);
                    this.name_group.Text = this.query_get_g.dataset.Tables[0].Rows[0]["name"].ToString();

                    this.comboBoxSpecialization.SelectedValue = int.Parse(this.query_get_g.dataset.Tables[0].Rows[0]["spec"].ToString());
                    this.comboBoxTeacher.SelectedValue = int.Parse(this.query_get_g.dataset.Tables[0].Rows[0]["curator"].ToString());

                    this.dataGridStudents.DataSource = this.query_get_students.dataset.Tables[0];
                    this.SchedulesDay.DataSource = this.query_get_schedules.dataset.Tables[0];
                }

               
                

        }
        private void Window_Load(object sender, EventArgs e)
        {
            this.FillControls();
            ///128;
        }

        private void EditButton1_Click(object sender, EventArgs e)
        {
            Window.Window_Schedules win = new Window.Window_Schedules();
            win.Show((int)this.query_get_g.dataset.Tables[0].Rows[0]["id"]);
            this.FillControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog.Dialog_SAE_Students win = new Dialog_SAE_Students();
            win.Show(1);
            this.FillControls();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.state == 1)
                query_set_g.Group = id;
            else
                query_set_g.Group = -1;
            query_set_g.run(DataManager._connection);
            iquery_g.Set_Insert_Data(name_group.Text,(int)comboBoxSpecialization.SelectedValue,(int)comboBoxTeacher.SelectedValue);
            iquery_g.run(DataManager._connection);
            this.Close();
        }

        private void buttonOpenLog_Click(object sender, EventArgs e)
        {
            Window.Window_Log win = new Window.Window_Log();
            win.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLogMySQL.Components.Graphics.States.SubStates;
namespace AppLogMySQL.Components.Graphics.States
{
    public partial class State_ControllPanel : UserControl
    {
        string Permision = "";
        public State_ControllPanel()
        {
            InitializeComponent();
            InitializeFunction();
            InitializeVars();

            
        }


        private void formingAdmin() {
            buttonDiscipline.Enabled = true;
            buttonGroups.Enabled = true;
            buttonSpecialization.Enabled = true;
            buttonLogs.Enabled = true;
        }

        private void formingTeacher(){
            buttonDiscipline.Enabled = false;
            buttonGroups.Enabled = false;
            buttonSpecialization.Enabled = false;
            buttonLogs.Enabled = true;
        }

        private void formingStudents(){
            buttonDiscipline.Enabled = false;
            buttonGroups.Enabled = false;
            buttonSpecialization.Enabled = false;
            buttonLogs.Enabled = false;
        }

        private void InitializeFunction()
        {
            this.Load += new System.EventHandler(this.On_Load);
            this.buttonExitSystem.Click += new System.EventHandler(this.Logut);

            this.buttonExitSystem.Click += new System.EventHandler(this.Logut);
            this.buttonGroups.Click += new System.EventHandler(this.Show_All_Group);
            this.buttonSpecialization.Click += new System.EventHandler(this.Show_All_Specialization);
            this.buttonDiscipline.Click += new System.EventHandler(this.Show_All_Discipline);
            //this.buttonCuriculumb.Click += new System.EventHandler(this.Show_All_Curriculumb);
        }

        private void InitializeVars()
        {
            this.Dock = DockStyle.Fill;
            Data.DataManager.substate_states = panelControlls;
            panelControlls.add_State("UserProfile", new SubStates_UserProfile());
        }

        private void On_Load(object sender, EventArgs e)
        {
            panelControlls.state_Change("UserProfile");

        }
        
        private void Logut(object sender, EventArgs e)
        {
            Components.Data.DataManager.generalForm.labelTitle.Text = string.Format("Электронный журнал успеваемости");
            Components.Data.DataManager.global_states.state_Change("Authorization");
        }

        private void Show_All_Curriculumb(object sender, EventArgs e)
        {
            Window.Show_all.Window_Curriculumbs win = new Window.Show_all.Window_Curriculumbs();
            win.ShowDialog();
        }

        private void Show_All_Discipline(object sender, EventArgs e)
        {
            Window.Show_all.Window_Disciplines win = new Window.Show_all.Window_Disciplines();
            win.ShowDialog();
        }

        private void Show_All_Group(object sender, EventArgs e)
        {
            Window.Show_all.Windows_Groups win = new Window.Show_all.Windows_Groups();
            win.ShowDialog();
        }

        private void Show_All_Specialization(object sender, EventArgs e)
        {
            Window.Show_all.Window_Specializations win = new Window.Show_all.Window_Specializations();
            win.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog.Window_Open_Logs win = new Dialog.Window_Open_Logs();
            win.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            AppLogMySQL.Components.Data.DataManager._account.FillData();
            Permision = AppLogMySQL.Components.Data.DataManager._account._dataset.Tables[0].Rows[0]["Права доступа:"].ToString();

            switch (Permision)
            {
                case "Администратор": formingAdmin(); break;
                case "Преподаватель": formingTeacher(); break;
                case "Студент": formingStudents(); break;
                default: break;
            }
            base.OnPaint(e);
        }

        private void buttonExitSystem_Click(object sender, EventArgs e)
        {

        }
    }
}
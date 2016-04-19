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
        public State_ControllPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Data.DataManager.substate_states = panelControlls;
            //panelControlls.add_State("Schedules", new SubStates_Schedules());
            panelControlls.add_State("UserProfile", new SubStates_UserProfile());
            panelControlls.add_State("Disciplines", new SubStates_Disciplines());
        }

        private void buttonShowLogs_Click(object sender, EventArgs e)
        {
            Window.Window_Log win = new Window.Window_Log();
            win.ShowDialog();
            //this.panelLogFilter.Visible = !this.panelLogFilter.Visible;
        }

        private void buttonClearD_Click(object sender, EventArgs e)
        {
            comboBoxDiscipline.SelectedIndex = -1;
        }

        private void buttonClearG_Click(object sender, EventArgs e)
        {
            comboBoxGroup.SelectedIndex = -1;
        }

        private void buttonExitSystem_Click(object sender, EventArgs e)
        {
            
            Components.Data.DataManager.generalForm.labelTitle.Text = string.Format("Электронный журнал успеваемости");
            Components.Data.DataManager.global_states.back();
            panelControlls.state_Change("UserProfile");
        }

        private void UC_ControllPanel_Load(object sender, EventArgs e)
        {
            AppLogMySQL.Components.Data.DataManager._account.FillData();
            panelControlls.state_Change("UserProfile");
        }
        private void buttonShowWeekLog_Click(object sender, EventArgs e)
        {
            Window.Window_Schedules win = new Window.Window_Schedules();
            win.ShowDialog();
        }

        private void buttonShowCuriculumb_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Window.Window_Disciplines win = new Window.Window_Disciplines();
            win.ShowDialog();
        }
    }
}

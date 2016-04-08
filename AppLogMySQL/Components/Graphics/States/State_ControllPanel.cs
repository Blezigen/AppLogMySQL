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
        SubStates_UserProfile UserProfile;
        SubStates_Schedules substate_Schedules;
        SubStates_LogList LogList;
        public State_ControllPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            //Panels.PanelLog p = new Panels.PanelLog();
        }

        private static void DisplayDataGroupComboBox(System.Data.DataTable table, ComboBox d, string param_name)
        {
            d.Items.Clear();
            foreach (System.Data.DataRow row in table.Rows)
            {
                d.Items.Add(row[param_name]);
            }
        }

        private void DisplayDataInGrid(System.Data.DataTable table, DataGridView d)
        {
            d.Rows.Clear();
            LogList.d = table;
            foreach (System.Data.DataRow row in table.Rows)
            {
                d.Rows.Add(row[0], row["group_name"], row["discipline_name"]);
                //Console.WriteLine("{0} : {1} = {2}", row["row_number"], row["group_name"], row["discipline_name"]);
            }
        }

        public void OnLoad()
        {
            //LabelName.Text = string.Format("Имя: {0}",DataCollection.account._full_name);
            //GroupComboBox.Items;
        }
        public void DefaultView()
        {
            //LabelName.Text = string.Format("Имя: {0}",DataCollection.account._full_name);
            //GroupComboBox.Items;
        }

        private void comboBoxDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataCollection.PanelControllData.selected_discipline_logs = comboBoxDiscipline.SelectedIndex;
            //DisplayDataInGrid(DataCollection.queryGetListLogsData(DataCollection.AccountData._id), LogList.dataGridViewLogs);
        }

        private void comboBoxGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //DataCollection.PanelControllData.selected_group_logs = comboBoxGroup.SelectedIndex;
            //DisplayDataInGrid(DataCollection.queryGetListLogsData(DataCollection.AccountData._id), LogList.dataGridViewLogs);
        }

        private void buttonShowLogs_Click(object sender, EventArgs e)
        {
            this.panelLogFilter.Visible = !this.panelLogFilter.Visible;
            this.Invalidate();
            /*if (DataCollection.AccountData._type == "worker" && this.panelLogFilter.Visible)
            {
                Console.WriteLine("StartForming");
                panelControlls.Controls.Clear();
                panelControlls.Controls.Add(LogList);
                DataCollection.GroupCollection = DataCollection.queryGetGroupsData();
                DataCollection.DisciplineCollection = DataCollection.queryGetDisciplineData();
                //DisplayDataInGrid(DataCollection.queryGetListLogsData(DataCollection.AccountData._id), LogList.dataGridViewLogs);
                DisplayDataGroupComboBox(DataCollection.GroupCollection, comboBoxGroup, "group_name");
                DisplayDataGroupComboBox(DataCollection.DisciplineCollection, comboBoxDiscipline, "discipline_name");
                //DisplayDataGroupComboBox(DataCollection.queryGetGroupsData(DataCollection.account._id), GroupComboBox);
            }
            else
            {
                panelControlls.Controls.Clear();
                panelControlls.Controls.Add(UserProfile);
            }*/
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
        }

        private void UC_ControllPanel_Load(object sender, EventArgs e)
        {
            AppLogMySQL.Components.Data.DataManager._account.FillData();
            UserProfile = new SubStates_UserProfile();
            LogList = new SubStates_LogList();
            UserProfile.BackColor = Color.Red;
            UserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                               | System.Windows.Forms.AnchorStyles.Right)));
            panelControlls.Controls.Clear();
            UserProfile.Location = new Point(1, 1);
            UserProfile.Size = new System.Drawing.Size(panelControlls.Width - 2, panelControlls.Height - 2);
            panelControlls.Controls.Add(UserProfile);

            UserProfile.Load();
        }

        private void dataGridViewLogs_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            //Panels.PanelLog p = new Panels.PanelLog();
            //DataCollection._NextForm(p);
        }

        private void buttonShowWeekLog_Click(object sender, EventArgs e)
        {
            panelControlls.Controls.Clear();
            substate_Schedules = new SubStates_Schedules();
            substate_Schedules.BackColor = Color.Red;
            substate_Schedules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                   | System.Windows.Forms.AnchorStyles.Right)));
            substate_Schedules.Location = new Point(1, 1);
            substate_Schedules.Dock = DockStyle.None;
            //substate_Schedules.Size = new System.Drawing.Size(panelControlls.Width - 2, panelControlls.Height - 2);
            panelControlls.Controls.Add(substate_Schedules);
            
            //substate.Load();
        }
    }
}

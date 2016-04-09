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
using AppLogMySQL.Components.MySql.InsertQuerys;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Windows
{
    public partial class EditSchedulesDateOfWeek : Form
    {
        Dictionary<String,object> Disciplines;
        public int group;
        public int sch_day;
        public EditSchedulesDateOfWeek()
        {
            InitializeComponent();
        }

        private void EditSchedulesDateOfWeek_Load(object sender, EventArgs e)
        {
            labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            labelTitle.ForeColor = Color.FromArgb(243, 237, 210);
            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                Invalidate();
            };
            fill();
        }


        void fill() {
            MySql.SelectQuerys.SQuery_GetSchedules query_Shudels = new MySql.SelectQuerys.SQuery_GetSchedules();
            MySql.SelectQuerys.SQuery_Set_Group set_group_query = new MySql.SelectQuerys.SQuery_Set_Group(group);
            MySql.SelectQuerys.SQuery_GetAffordableDisciplineByGroup query = new MySql.SelectQuerys.SQuery_GetAffordableDisciplineByGroup();
            set_group_query.run(Data.DataManager._connection);
            query_Shudels.run(Data.DataManager._connection);
            query.run(AppLogMySQL.Components.Data.DataManager._connection);
            Disciplines = query.getFormatData();
            Dictionary<string, object> oldData = query_Shudels.getFormatData();

            List<string> stringlist = new List<string>();
            stringlist.Add("Пустой урок");
            foreach (KeyValuePair<string, object> val in Disciplines)
            {
                stringlist.Add(val.Value.ToString());
            }
            DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)SchedulesDayData.Columns[1];
            combo.DataSource = stringlist;


            SchedulesDayData.Rows.Clear();
            for (int i = 1; i <= 7; i++)
                SchedulesDayData.Rows.Add(i.ToString(), "");
            for (int i = 0; i <= 6; i++)
                setSelectedIndex((DataGridViewComboBoxCell)SchedulesDayData.Rows[i].Cells[1], 0);
            IDictionary rowa = oldData as IDictionary;
            bool ifki = false;
            foreach (KeyValuePair<string, object> val in oldData)
                if (val.Key == sch_day.ToString())
                {
                    rowa = (IDictionary)val.Value;
                    ifki = true;
                }
            if (ifki)
            {
                foreach (DictionaryEntry vals in rowa)
                {
                    setSelectedIndex((DataGridViewComboBoxCell)SchedulesDayData.Rows[int.Parse(vals.Key.ToString()) - 1].Cells[1], vals.Value);
                    // d.Rows[int.Parse(vals.Key.ToString())].Cells[1].Value = .ToString();
                }
            }
                //setSelectedIndex((DataGridViewComboBoxCell)SchedulesDayData.Rows[i].Cells[1], 0);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SchedulesDayData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int getSelectedIndex(DataGridViewComboBoxCell ld)
        {
            return ld.Items.IndexOf(ld.Value);
        }

        public void setSelectedIndex(DataGridViewComboBoxCell ld,int value)
        {
            ld.Value = ld.Items[value];
        }

        public void setSelectedIndex(DataGridViewComboBoxCell ld, object value)
        {
            ld.Value = value;
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> stringlist = new List<string>();

                foreach (DataGridViewRow row in SchedulesDayData.Rows)
                {
                    DataGridViewComboBoxCell ld = (DataGridViewComboBoxCell) row.Cells[1];
                    if (getSelectedIndex(ld) > 0) { 
                        var item = Disciplines.ElementAt(getSelectedIndex(ld)-1);
                        stringlist.Add(item.Key.ToString());
                    }
                    else
                    {
                        stringlist.Add("");
                    }
                    //ld.
                    //returnData.Add(row["id_d"].ToString(),row["discipline_name"].ToString());
                }
                Accept(stringlist);
                Close();
        }

        void Accept(List<string> stringlist)
        {
            IQuery_Insert_in_schedule isch = new IQuery_Insert_in_schedule();
            SQuery_Set_WeekDay wd = new SQuery_Set_WeekDay(sch_day);
            SQuery_Set_Group g = new SQuery_Set_Group(group);
            SQuery_Set_Discipline d = new SQuery_Set_Discipline(0);
            SQuery_Set_Para p = new SQuery_Set_Para(0);

            g.run(DataManager._connection);
            wd.run(DataManager._connection);
            for (int i = 0; i < 7; i++)
            {
                if (stringlist[i] != "")
                {
                    d.Discipline = int.Parse(stringlist[i]);
                    p.Para = i + 1;
                }
                else
                {
                    d.Discipline = 0;
                    p.Para = i + 1;
                }
                p.run(DataManager._connection);
                d.run(DataManager._connection);
                isch.run(DataManager._connection);
            }
            //listBox1.Items.Clear();    
            //listBox1.Items.AddRange(stringlist.ToArray());
        }
        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ((ComboBox)sender).SelectedIndex;
            //MessageBox.Show("Selected Index = " + selectedIndex);
        }

        private void SchedulesDayData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (SchedulesDayData.CurrentCell.ColumnIndex == 1)
            {
                // Check box column
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            }
        }
    }
}

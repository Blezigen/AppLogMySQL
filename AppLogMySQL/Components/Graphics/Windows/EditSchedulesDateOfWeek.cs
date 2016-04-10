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

namespace AppLogMySQL.Components.Graphics.Windows
{
    public partial class EditSchedulesDateOfWeek : Form
    {
        SQuery_GetLoadPolitic query_lp;

        SQuery_Set_Group query_g;
        SQuery_Set_Discipline query_d;
        SQuery_Set_WeekDay query_wd;
        SQuery_Set_Para query_p;
        SQuery_Set_Teacher query_t;

        SQuery_GetSchedules query_s;
        SQuery_GetAffordableDisciplineByGroup query_ADBG;
        IQuery_Insert_in_schedule insert_isch;


        Dictionary<string, object> Disciplines;
        Dictionary<string, object> Disciplines_OldData;
        Dictionary<int, Dictionary<string, object>> ComboBoxINT;

        public int group;
        public int sch_day;

        private bool showHideOption;

        List<string> getItemsComboBOXGrid(Dictionary<string, object> d)
        {
            List<string> stringlist = new List<string>();
            stringlist.Add("Пустой урок");
            foreach (KeyValuePair<string, object> val in d)
                stringlist.Add(val.Value.ToString());
            return stringlist;
        }

        List<string> getItemsComboBOXTeacher(Dictionary<string, object> d)
        {
            List<string> stringlist = new List<string>();
            foreach (KeyValuePair<string, object> val in d)
                stringlist.Add(val.Value.ToString());
            return stringlist;
        }

        List<string> FormatInsertQuerys()
        {
            List<string> stringlist = new List<string>();

            foreach (DataGridViewRow row in SchedulesDayData.Rows)
            {
                if (getSelectedIndex((DataGridViewComboBoxCell)row.Cells[1]) > 0)
                {
                    var item = Disciplines.ElementAt(getSelectedIndex((DataGridViewComboBoxCell)row.Cells[1]) - 1);
                    stringlist.Add(item.Key.ToString());
                }
                else
                    stringlist.Add("");
            }
            return stringlist;
        }

        public int getSelectedIndex(DataGridViewComboBoxCell ld)
        {
            return ld.Items.IndexOf(ld.Value);
        }

        public void setSelectedIndex(DataGridViewComboBoxCell ld, int value)
        {
            ld.Value = ld.Items[value];
        }

        public void setSelectedIndex(DataGridViewComboBoxCell ld, object value)
        {
            ld.Value = value;
        } 


        public EditSchedulesDateOfWeek()
        {
            InitializeComponent();

            labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            labelTitle.ForeColor = Color.FromArgb(243, 237, 210);

            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                Invalidate();
            };

            ComboBoxINT = new Dictionary<int,Dictionary<string,object>>();
            Disciplines = new Dictionary<string,object>();
            Disciplines_OldData = new Dictionary<string, object>();

            query_s = new SQuery_GetSchedules();
            query_g = new SQuery_Set_Group(group);
            query_wd = new SQuery_Set_WeekDay(sch_day);
            query_p = new SQuery_Set_Para(0);
            query_d = new SQuery_Set_Discipline(0);
            query_t = new SQuery_Set_Teacher(0);

            query_ADBG = new SQuery_GetAffordableDisciplineByGroup();
            query_lp = new SQuery_GetLoadPolitic();
            insert_isch = new IQuery_Insert_in_schedule();
        }

        private void EditSchedulesDateOfWeek_Load(object sender, EventArgs e)
        {
        }

        void fillDataGrid() {
            query_g.run(Data.DataManager._connection);
            query_s.run(Data.DataManager._connection);
            query_ADBG.run(AppLogMySQL.Components.Data.DataManager._connection);

            Disciplines = query_ADBG.getFormatData();
            Disciplines_OldData = query_s.getFormatData();

            ((DataGridViewComboBoxColumn)SchedulesDayData.Columns[1]).DataSource = getItemsComboBOXGrid(Disciplines);

            SchedulesDayData.Rows.Clear();
            for (int i = 1; i <= 7; i++)
                SchedulesDayData.Rows.Add(i.ToString(), "");
            for (int i = 0; i <= 6; i++)
                setSelectedIndex((DataGridViewComboBoxCell)SchedulesDayData.Rows[i].Cells[1], 0);

            IDictionary RowDiscipline = Disciplines_OldData as IDictionary;
            bool ifki = false;
            foreach (KeyValuePair<string, object> val in Disciplines_OldData)
                if (val.Key == sch_day.ToString())
                {
                    RowDiscipline = (IDictionary)val.Value;
                    ifki = true;
                }
            if (ifki)
                foreach (DictionaryEntry vals in RowDiscipline)
                    setSelectedIndex((DataGridViewComboBoxCell)SchedulesDayData.Rows[int.Parse(vals.Key.ToString()) - 1].Cells[1], vals.Value);

        }

        void fillComboBoxes()
        {
            query_g.run(Data.DataManager._connection);
            for (int i = 0; i < 7; i++)
            {
                ComboBox c = (this.Controls.Find(string.Format("comboBox{0}", (i + 1)), false)[0]) as ComboBox;
                if (getSelectedIndex((DataGridViewComboBoxCell)SchedulesDayData.Rows[i].Cells[1]) > 0)
                {
                    query_d.Discipline = int.Parse(Disciplines.ElementAt(getSelectedIndex((DataGridViewComboBoxCell)SchedulesDayData.Rows[i].Cells[1]) - 1).Key);
                    query_d.run(Data.DataManager._connection);
                    query_lp.run(Data.DataManager._connection);
                    c.DataSource = getItemsComboBOXTeacher(query_lp.getFormatData());
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

               
        private void button2_Click(object sender, EventArgs e)
        {
                Accept(FormatInsertQuerys());
                Close();
        }

        void Accept(List<string> stringlist)
        {
            query_g.run(DataManager._connection);
            query_wd.run(DataManager._connection);
            for (int i = 0; i < 7; i++)
            {
                if (stringlist[i] != "")
                {
                    
                    query_d.Discipline = int.Parse(stringlist[i]);
                    query_p.Para = i + 1;
                }
                else
                {
                    query_d.Discipline = 0;
                    query_p.Para = i + 1;
                }
                query_t.run(DataManager._connection);
                query_p.run(DataManager._connection);
                query_d.run(DataManager._connection);
                insert_isch.run(DataManager._connection);
            }
        }

        private void EditSchedulesDateOfWeek_Shown(object sender, EventArgs e)
        {
            showHideOption = false;
            query_g.Group = group;
            query_wd.Weekday = sch_day;
            fillDataGrid();
            fillComboBoxes();
            Width = 250;
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {
            showHideOption = !showHideOption;
            if (showHideOption)
                this.Width = 500;
            else
                this.Width = 250;
        }
    }
}

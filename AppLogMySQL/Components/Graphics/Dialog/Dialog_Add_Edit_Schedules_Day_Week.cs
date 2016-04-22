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
        SQuery_Get_Load_Politic query_lp;

       // SQuery_Set_Group query_g;
        SQuery_Set_Discipline query_d;
        SQuery_Set_WeekDay query_wd;
        SQuery_Set_Para query_p;
        SQuery_Set_Teacher query_t;

        SQuery_Get_Schedules query_s;
        SQuery_Get_Affordable_Discipline_By_Group query_ADBG;
        IQuery_Insert_Schedule insert_isch;


        //Dictionary<string, object> Disciplines;
        Dictionary<string, object> Disciplines_OldData;
        Dictionary<int, Dictionary<string, object>> ComboBoxINT;

        public int group;
        public int weekday;

        private bool showHideOption;
        private bool on_show;

        List<string> FormatInsertQuerys()
        {
            List<string> stringlist = new List<string>();

            foreach (DataGridViewRow row in SchedulesDayData.Rows)
            {
                    if (((DataGridViewComboBoxCell)row.Cells[1]).Value != null && int.Parse(((DataGridViewComboBoxCell)row.Cells[1]).Value.ToString()) > 0)
                    {
                        stringlist.Add(((DataGridViewComboBoxCell)row.Cells[1]).Value.ToString());
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


        public Dialog_Add_Edit_Schedules_Day_Week()
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
            
            Disciplines_OldData = new Dictionary<string, object>();

            query_s = new SQuery_Get_Schedules();
            //query_g = new SQuery_Set_Group(group);
            query_wd = new SQuery_Set_WeekDay(weekday);
            query_p = new SQuery_Set_Para(0);
            query_d = new SQuery_Set_Discipline(0);
            query_t = new SQuery_Set_Teacher(0);

            query_ADBG = new SQuery_Get_Affordable_Discipline_By_Group();
            query_lp = new SQuery_Get_Load_Politic();
            insert_isch = new IQuery_Insert_Schedule();
        }

        private void EditSchedulesDateOfWeek_Load(object sender, EventArgs e)
        {
        }

        void fillDataGrid() {

            //this.query_g.run(Data.DataManager._connection);
            this.query_wd.Weekday = weekday;
            this.query_wd.run(DataManager._connection);
            this.query_s.run(Data.DataManager._connection);
            this.query_ADBG.run(AppLogMySQL.Components.Data.DataManager._connection);

            DataGridViewComboBoxColumn g = (DataGridViewComboBoxColumn)SchedulesDayData.Columns[1];

            g.DataSource = query_ADBG.dataset.Tables[0];
            g.DisplayMember = "name";
            g.ValueMember = "id";
            g.ValueType = typeof(int);

            DataTable dt = ((DataTable)query_s.dataset.Tables[0]);
            try
            {
                for (int i = 1; i <= 7; i++)
                    this.SchedulesDayData.Rows.Add(i.ToString(), Convert.ToInt32(dt.Rows[i - 1].ItemArray[0].ToString()));
            }
            catch(IndexOutOfRangeException)
            {
                this.SchedulesDayData.Rows.Clear();
                for (int i = 1; i <= 7; i++)
                    this.SchedulesDayData.Rows.Add(i.ToString(), 0);
            }
        }

        void fillComboBoxes()
        {
            if (this.showHideOption)
            {
                //this.query_g.run(Data.DataManager._connection);
                for (int i = 0; i < 7; i++)
                {
                    ComboBox c = ((ComboBox)this.Controls.Find(string.Format("comboBox{0}", (i + 1)), false)[0]);
                        c.Enabled = true;
                        var v = ((DataGridViewComboBoxCell)this.SchedulesDayData.Rows[i].Cells[1]).Value;
                        if (v != null)
                        {
                            this.query_d.Discipline = int.Parse(v.ToString());
                            this.query_d.run(Data.DataManager._connection);
                            this.query_lp.run(Data.DataManager._connection);
                            c.DataSource = this.query_lp.dataset.Tables[0];

                            c.DisplayMember = "name";
                            c.ValueMember = "id";
                            try
                            {
                                if (((DataTable)c.DataSource).Select(string.Format("id = {0}", query_s.dataset.Tables[0].Rows[i].ItemArray[4])).Count() > 0)
                                {
                                    c.SelectedValue = int.Parse(query_s.dataset.Tables[0].Rows[i].ItemArray[4].ToString());
                                }
                                else
                                {
                                    c.ValueMember = "is_default";
                                    c.SelectedValue = 1;
                                    c.ValueMember = "id";
                                }
                            }
                            catch(IndexOutOfRangeException)
                            {
                                c.ValueMember = "is_default";
                                c.SelectedValue = 1;
                                c.ValueMember = "id";
                                //c.SelectedValue = 0;

                            }
                        }
                        else
                        {
                            ((DataGridViewComboBoxCell)this.SchedulesDayData.Rows[i].Cells[1]).Value = 0;
                            c.DataSource = null;
                            c.SelectedValue = 0;
                            c.Enabled = false;
                            c.Items.Clear();
                        }
                }
                this.Invalidate();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.on_show = false;
            this.Close();
        }
               
        private void button2_Click(object sender, EventArgs e)
        {
            this.on_show = false;
            this.Accept(this.FormatInsertQuerys());
            this.Close();
        }

        void Accept(List<string> stringlist)
        {
            #if (DEBUG)
            Console.WriteLine(string.Format("<=============================================================================== Start [INSERT] Schedules =="));
                Console.WriteLine(string.Format("<============================================================ Start [INIT] Option =="));
            #endif
           // this.query_g.run(DataManager._connection);
            this.query_wd.run(DataManager._connection);
            //this.query_g.Group = group;
            this.query_wd.Weekday = weekday;
            #if (DEBUG)
            Console.WriteLine(string.Format("<============================================================ End [INIT] Option =="));
            #endif
            for (int i = 0; i < 7; i++)
            {
                #if (DEBUG)
                Console.WriteLine(string.Format("<============================================================ Start [ITEM {0}] Option ==", i));
                #endif
                ComboBox c = ((ComboBox)this.Controls.Find(string.Format("comboBox{0}", (i + 1)), false)[0]);
                if (stringlist[i] != "")
                {
                    if (!this.showHideOption)
                        this.query_t.Teacher = -1;
                    else
                    {
                        if (((DataRowView)c.SelectedItem) != null)
                        {
                            this.query_t.Teacher = int.Parse(((DataRowView)c.SelectedItem).Row.ItemArray[0].ToString());
                        }
                        else
                        {
                            this.query_t.Teacher = 0;
                        }
                    }
                    this.query_d.Discipline = int.Parse(stringlist[i]);
                    this.query_p.Para = i + 1;
                }
                else
                {
                    this.query_d.Discipline = 0;
                    this.query_p.Para = i + 1;
                }
                this.query_t.run(DataManager._connection);
                this.query_p.run(DataManager._connection);
                this.query_d.run(DataManager._connection);
                #if (DEBUG)
                    Console.WriteLine(string.Format("<============================================================ END [ITEM {0}] Option ==", i));
                    Console.WriteLine(string.Format("<============================================================ Start [INSERT] ==", i));
                #endif
                this.insert_isch.run(DataManager._connection);
                #if (DEBUG)
                Console.WriteLine(string.Format("<============================================================ END [INSERT] ==", i));
                #endif
            }
            #if (DEBUG)
            Console.WriteLine(string.Format("<=============================================================================== End [INSERT] Schedules =="));
            #endif
        }

        private void EditSchedulesDateOfWeek_Shown(object sender, EventArgs e)
        {
            this.showHideOption = false;
           // this.query_g.Group = this.group;
            this.query_wd.Weekday = this.weekday;
            this.Width = this.MinimumSize.Width;
            this.SchedulesDayData.Rows.Clear();
            this.fillDataGrid();
            this.on_show = true;
        }
        private void noEditGrid()
        {
            for (int i = 0; i < 7; i++)
                ((DataGridViewComboBoxCell)this.SchedulesDayData.Rows[i].Cells[1]).ReadOnly = true;
            EditButton2.Enabled = false;
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Будет недоcтупно изменение предметов. Согласны?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                noEditGrid();
                this.showHideOption = !this.showHideOption;
                if (this.showHideOption)
                    this.Width = this.MinimumSize.Width * 2;
                else
                    this.Width = this.MinimumSize.Width;
                this.fillComboBoxes();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.on_show = false;
            this.Close();
        }

    }
}

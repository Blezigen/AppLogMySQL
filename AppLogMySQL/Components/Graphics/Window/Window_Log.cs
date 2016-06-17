using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.MySql.SelectQuerys;

namespace AppLogMySQL.Components.Graphics.Window
{
    public partial class Window_Log : Form
    {
        private SQuery_Set_Discipline query_set_d;
        private SQuery_Set_Group query_set_g;
        private SQuery_Set_Log_Month query_set_month;
        private SQuery_Set_Log_Year query_set_year;

        private SQuery_Get_Logs query_get_l;
        private DataTable _data;

        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn hide_id;
        private DataGridViewTextBoxColumn Full_Name;


        public int Discipline
        {
            get { return query_set_d.Discipline; }
            set { query_set_d.Discipline = value; }
        }

        public int Group
        {
            get { return query_set_g.Group; }
            set { query_set_g.Group = value; }
        }

        public Window_Log()
        {
            #if (DEBUG)
                Console.WriteLine("Инициализация");
            #endif
            InitializeComponent();

            this.Text = "Журнал";
            this.Icon = global::AppLogMySQL.ResourceApplication.AppIco;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            this.labelTitle.ForeColor = Color.FromArgb(243, 237, 210);
            InitializeFunction();
            InitializeVars();
     
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
            this.CloseButton.MouseUp += delegate
            {
                this.Close();
            };
        }
        private void InitializeVars()
        {
            this.query_set_g = new SQuery_Set_Group(-1);
            this.query_set_d = new SQuery_Set_Discipline(-1);
            this.query_get_l = new SQuery_Get_Logs();
            this.query_set_month = new SQuery_Set_Log_Month();
            this.query_set_year = new SQuery_Set_Log_Year(); 

            this._data = new DataTable();

            this.Number = new DataGridViewTextBoxColumn();
            this.hide_id = new DataGridViewTextBoxColumn();
            this.Full_Name = new DataGridViewTextBoxColumn();

            ///////
            // 
            // Number
            // 
            this.Number.DataPropertyName = "numberx";
            this.Number.FillWeight = 23F;
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 23;
            // 
            // hide_id
            // 
            this.hide_id.DataPropertyName = "id_account";
            this.hide_id.HeaderText = "idd";
            this.hide_id.Name = "hide_id";
            this.hide_id.Visible = false;
            this.hide_id.ReadOnly = true;
            this.hide_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hide_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hide_id.Width = 0;
            // 
            // Full_Name
            // 
            this.Full_Name.DataPropertyName = "full_name";
            this.Full_Name.FillWeight = 250F;
            this.Full_Name.HeaderText = "Ф.И.О";
            this.Full_Name.MinimumWidth = 250;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            this.Full_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Full_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Full_Name.Width = 250;
            ///////


            this.GeneralDataGrid.AutoGenerateColumns = false;

            this.query_set_year.Year = 2015;
            this.query_set_month.Month = 9;
            
         }
        private void FillControls()
        {
            #if (DEBUG)
                        Console.WriteLine("Заполнение элементов");
            #endif

            this._data.Clear();
            this._data.Columns.Clear();
            this.GeneralDataGrid.Columns.Clear();

            this.query_set_month.run(Data.DataManager._connection);
            this.query_set_year.run(Data.DataManager._connection);
            this.query_set_d.run(Data.DataManager._connection);
            this.query_set_g.run(Data.DataManager._connection);
            this.query_get_l.run(Data.DataManager._connection);
            this._data = this.query_get_l.dataset.Tables[0];
           

            this.GeneralDataGrid.Columns.Add(this.Number);
            this.GeneralDataGrid.Columns.Add(this.hide_id);
            this.GeneralDataGrid.Columns.Add(this.Full_Name);

            for (int l = 3; l < this._data.Columns.Count; l++)
            {
                DataGridViewButtonColumn data = new DataGridViewButtonColumn();
                    data.DataPropertyName = this._data.Columns[l].ColumnName;
                    data.HeaderText = this._data.Columns[l].ColumnName;
                    data.Name = string.Format("column_{0}", this._data.Columns[l].ColumnName);
                    data.ReadOnly = true;
                    data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
                    data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                    data.Width = 23;
                this.GeneralDataGrid.Columns.Add(data);
            }

            this.GeneralDataGrid.DataSource = this._data;

            DataGridViewTextBoxColumn Column_Filler = new DataGridViewTextBoxColumn();
                Column_Filler.FillWeight = 250F;
                Column_Filler.HeaderText = "";
                Column_Filler.Name = "Column_Filler";
                Column_Filler.ReadOnly = true;
                Column_Filler.Resizable = System.Windows.Forms.DataGridViewTriState.False;
                Column_Filler.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                Column_Filler.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Column_Filler.Width = 23;
                Column_Filler.DisplayIndex = 30;
            this.GeneralDataGrid.Columns.Add(Column_Filler);
            


        }
        private void Window_Load(object sender, EventArgs e)
        {
        }

        private void TabControll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GeneralDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                if ((GeneralDataGrid.Columns[e.ColumnIndex].GetType().Equals(typeof(DataGridViewButtonColumn))))
                {
                    //Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Dialog.Dialog_SAE_Log_Value d = new Dialog.Dialog_SAE_Log_Value();

                    int yea = query_set_year.Year;
                    int mon = query_set_month.Month;
                    int day = int.Parse(GeneralDataGrid.Columns[e.ColumnIndex].HeaderText);
                    string v = _data.Rows[e.RowIndex][e.ColumnIndex].ToString();
                    d.Show((int)_data.Rows[e.RowIndex]["id_account"],query_set_d.Discipline, yea, mon, day, v);
                    FillControls();
                }
            }
        }

        public bool Show(int i)
        {

            FillControls();
            this.ShowDialog();
            return true;
        }


        private void TabControll_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: this.query_set_month.Month = 9; this.query_set_year.Year = 2015; break;
                case 1: this.query_set_month.Month = 10; this.query_set_year.Year = 2015; break;
                case 2: this.query_set_month.Month = 11; this.query_set_year.Year = 2015; break;
                case 3: this.query_set_month.Month = 12; this.query_set_year.Year = 2015; break;
                case 4: this.query_set_month.Month = 1; this.query_set_year.Year = 2016; break;
                case 5: this.query_set_month.Month = 2; this.query_set_year.Year = 2016; break;
                case 6: this.query_set_month.Month = 3; this.query_set_year.Year = 2016; break;
                case 7: this.query_set_month.Month = 4; this.query_set_year.Year = 2016; break;
                case 8: this.query_set_month.Month = 5; this.query_set_year.Year = 2016; break;
                case 9: this.query_set_month.Month = 6; this.query_set_year.Year = 2016; break;
                case 10: this.query_set_month.Month = 7; this.query_set_year.Year = 2016; break;
            }
            this.FillControls();
            
        }

        private void GeneralDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                if ((GeneralDataGrid.Columns[e.ColumnIndex].GetType().Equals(typeof(DataGridViewTextBoxColumn))))
                {
                    if (e.ColumnIndex == 2)
                    {
                        Dialog.Dialog_SAE_Log_AVG d = new Dialog.Dialog_SAE_Log_AVG();
                        d.Show((int)_data.Rows[e.RowIndex]["id_account"]);
                    }
                }
            }
        }
    }
}

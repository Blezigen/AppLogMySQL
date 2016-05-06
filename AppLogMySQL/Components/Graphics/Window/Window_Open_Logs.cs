using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.VisualStyles;
using System.IO;
using AppLogMySQL.Components.Graphics.Controls;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.MySql.SelectQuerys;
using AppLogMySQL.Components.MySql.InsertQuerys;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Dialog
{
    public partial class Window_Open_Logs : Form
    {
        private SQuery_Set_Discipline query_set_d;
        private SQuery_Set_Group query_set_g;

        private SQuery_Get_Logs query_get_logs;

        public Window_Open_Logs()
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

        private void InitializeFunction()
        {
            this.Load += new System.EventHandler(this.Window_Disciplines_Load);
            this.GeneralDataGrid.CellClick += new DataGridViewCellEventHandler(this.GeneralDataGrid_CellClick);
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
            this.query_set_d = new SQuery_Set_Discipline(-1);
            this.query_set_g = new SQuery_Set_Group(-1);
            this.query_get_logs = new SQuery_Get_Logs();
            //this.query_get_students.Filter = "show_no_group";

        }


        private void FillControls()
        {
            #if (DEBUG)
                        Console.WriteLine("Заполнение элементов");
            #endif
            this.query_set_d.run(DataManager._connection);
            this.query_set_g.run(DataManager._connection);
            this.query_get_logs.run(DataManager._connection);
            this.GeneralDataGrid.AutoGenerateColumns = false;
            this.GeneralDataGrid.DataSource = this.query_get_logs.dataset.Tables[0];
        }

        private void Window_Disciplines_Load(object sender, EventArgs e)
        {
            this.FillControls();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Dialog.Dialog_Add_Edit_Discipline dialog = new Dialog.Dialog_Add_Edit_Discipline();
            dialog.Show(-1);
            this.FillControls();
        }

        public bool Show(int i)
        {
            query_set_d.Discipline = -1;
            query_set_g.Group = -1;
            this.ShowDialog();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GeneralDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                if ((GeneralDataGrid.Columns[e.ColumnIndex].GetType().Equals(typeof(DataGridViewButtonColumn))))// ||
                //  (GeneralDataGrid.Columns[e.ColumnIndex].GetType().Equals(typeof(DataGridViewImageButtonPrintColumn))))
                {
                    switch (e.ColumnIndex)
                    {
                        case 3:
                            Window.Window_Log win = new Window.Window_Log();
                            win.Discipline = (int)query_get_logs.dataset.Tables[0].Rows[e.RowIndex]["id_d"];
                            win.Group = (int)query_get_logs.dataset.Tables[0].Rows[e.RowIndex]["id_g"];
                            win.Show(1);
                            FillControls();
                            // In a real application you would code some real work here.
                            //txtStatusMsg.Text = "Button Clicked: Save " + GeneralDataGrid.
                            // Rows[e.RowIndex].Cells["Text"].Value.ToString();
                            //Dialog.Dialog_Add_Edit_Discipline dialog = new Dialog.Dialog_Add_Edit_Discipline();
                            //dialog.Show((int)query_get_d.dataset.Tables[0].Rows[e.RowIndex].ItemArray[1]);
                            //this.FillControls();
                            break;
                    }
                }
            }
        }
    }
}

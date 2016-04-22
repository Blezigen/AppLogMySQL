using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.MySql.SelectQuerys;
using System.Windows.Forms.VisualStyles;
using System.IO;
using AppLogMySQL.Components.Graphics.Controls;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.MySql.SelectQuerys;
using AppLogMySQL.Components.MySql.InsertQuerys;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Dialog
{
    public partial class Dialog_SAE_Students : Form
    {
        private SQuery_Get_Students query_get_students;
        private IQuery_Insert_Student_In_Group iquery;
        private int group = -1;

        public Dialog_SAE_Students()
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
            this.iquery = new IQuery_Insert_Student_In_Group();
            this.query_get_students = new SQuery_Get_Students();
            this.query_get_students.Filter = "show_no_group";

        }


        private void FillControls()
        {
            #if (DEBUG)
                        Console.WriteLine("Заполнение элементов");
            #endif
            this.Into_the_group.TrueValue = group; //Group;
            this.Into_the_group.FalseValue = System.DBNull.Value;
            this.query_get_students.run(Data.DataManager._connection);
            this.GeneralDataGrid.AutoGenerateColumns = false;
            this.GeneralDataGrid.DataSource = this.query_get_students.dataset.Tables[0];
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
            group = i;
            this.Into_the_group.TrueValue = group;//Group;
            this.ShowDialog();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ((DataTable) GeneralDataGrid.DataSource).Rows)
            {
                if(row["id_group"] == System.DBNull.Value){
                    iquery.Set_Insert_Data(row["id_account"].ToString(), "0");
                }
                else
                    iquery.Set_Insert_Data(row["id_account"].ToString(), "1");

                iquery.run(DataManager._connection);
            }
            FillControls();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

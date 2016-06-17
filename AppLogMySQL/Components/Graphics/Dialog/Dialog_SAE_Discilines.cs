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
    public partial class Dialog_SAE_Discilines : Form
    {
        private SQuery_Set_Discipline query_set_d;
        private SQuery_Get_Disciplines query_get_d;
        private IQuery_Insert_Curriculumb_Part_Discipline iquery;
        private int curriculum = -1;

        public Dialog_SAE_Discilines()
        {
            #if (DEBUG)
                Console.WriteLine("Инициализация");
            #endif
            InitializeComponent();

            this.Text = "Список доступных дисциплин для добаления";
            this.Icon = global::AppLogMySQL.ResourceApplication.AppIco;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

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
            this.iquery = new IQuery_Insert_Curriculumb_Part_Discipline();
            this.query_get_d = new SQuery_Get_Disciplines();
            this.query_set_d = new SQuery_Set_Discipline(-1);
            //this.query_get_students.Filter = "show_no_group";

        }


        private void FillControls()
        {
            #if (DEBUG)
                        Console.WriteLine("Заполнение элементов");
            #endif
            this.query_set_d.Discipline = -1;
            this.Into_the_group.TrueValue = 1; //Group;
            this.Into_the_group.FalseValue = 0;
            this.query_set_d.run(DataManager._connection);
            this.query_get_d.run(DataManager._connection);
            this.GeneralDataGrid.AutoGenerateColumns = false;
            this.GeneralDataGrid.DataSource = this.query_get_d.dataset.Tables[0];
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
            curriculum = i;
            this.Into_the_group.TrueValue = curriculum;//Group;
            this.ShowDialog();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in ((DataTable) GeneralDataGrid.DataSource).Rows)
            {
                query_set_d.Discipline = int.Parse(row["id"].ToString());
                iquery.Set_Insert_Data((int)row["check"]);
                query_set_d.run(DataManager._connection);
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

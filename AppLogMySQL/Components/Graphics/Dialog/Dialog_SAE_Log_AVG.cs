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
    public partial class Dialog_SAE_Log_AVG : Form
    {
        private SQuery_Set_Student query_set_s;
        private SQuery_Get_Logs_AVG query_get_avg;

        public Dialog_SAE_Log_AVG()
        {
            #if (DEBUG)
                Console.WriteLine("Инициализация");
            #endif
            InitializeComponent();

            this.Text = "Среднее значение по предметам";
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
            this.query_get_avg = new SQuery_Get_Logs_AVG();
            this.query_set_s = new SQuery_Set_Student();
            //this.query_get_students.Filter = "show_no_group";

        }


        private void FillControls()
        {
            #if (DEBUG)
                        Console.WriteLine("Заполнение элементов");
            #endif
            this.query_set_s.run(DataManager._connection);
            this.query_get_avg.run(DataManager._connection);
            this.GeneralDataGrid.AutoGenerateColumns = false;
            this.GeneralDataGrid.DataSource = this.query_get_avg.dataset.Tables[0];
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
            query_set_s.Student = i;
            //this.Into_the_group.TrueValue = curriculum;//Group;
            this.ShowDialog();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

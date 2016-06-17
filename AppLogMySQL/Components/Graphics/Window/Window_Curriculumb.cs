using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLogMySQL.Components.MySql.InsertQuerys;
using AppLogMySQL.Components.MySql.SelectQuerys;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Window
{
    public partial class Window_Curriculumb : Form
    {
        SQuery_Set_Curriculum query_set_c;
        SQuery_Get_Curriculum query_get_c;
        IQuery_Insert_Curriculumb_Part iquery_c;
        SQuery_Set_Discipline query_set_d;

        int curr;

        public Window_Curriculumb()
        {
            #if (DEBUG)
                Console.WriteLine("Инициализация");
            #endif
            InitializeComponent();

            this.Text = "Редактирование симестра";
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
            query_get_c = new SQuery_Get_Curriculum();
            query_set_c = new SQuery_Set_Curriculum(-1);
            iquery_c = new IQuery_Insert_Curriculumb_Part();
            query_set_d = new SQuery_Set_Discipline(-1);
            GeneralDataGrid.AutoGenerateColumns = false;
        }

        public bool Show(int id)
        {
            curr = id;
            LabelStudent.Text = string.Format("Настройте семестр {0}:",curr);
            this.FillControls();
            
            this.ShowDialog();
            return true;
        }

        private void FillControls()
        {
            #if (DEBUG)
                Console.WriteLine("Заполнение элементов");
            #endif
            query_set_c.Curriculum = curr;
            query_set_c.run(DataManager._connection);
            query_get_c.run(DataManager._connection);

            GeneralDataGrid.DataSource = query_get_c.dataset.Tables[0];
        }
        private void Window_Load(object sender, EventArgs e)
        {
            this.FillControls();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ((DataTable)GeneralDataGrid.DataSource).Rows)
            {
                iquery_c.Count_Lection = int.Parse(row["l"].ToString());
                iquery_c.Count_HomeWork = int.Parse(row["w"].ToString());
                iquery_c.Count_SelfWork = int.Parse(row["s"].ToString());
                iquery_c.Has_Credit = (ulong)row["c"] == 1;
                iquery_c.Has_Exam = (ulong)row["e"] == 1;
                query_set_d.Discipline = int.Parse(row["id_disp"].ToString());
                query_set_d.run(DataManager._connection);
                iquery_c.run(DataManager._connection);
            }
            FillControls();
            Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Dialog.Dialog_SAE_Discilines win = new Dialog.Dialog_SAE_Discilines();

            win.Show(curr);
            this.FillControls();
        }
    }
}

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
using AppLogMySQL.Components.MySql.InsertQuerys;

namespace AppLogMySQL.Components.Graphics.Dialog
{
    public partial class Dialog_Add_Edit_Discipline : Form
    {
        SQuery_Set_Discipline query_set_d;
        SQuery_Get_Disciplines query_get_d;
        IQuery_Insert_Discipline query_ins_d;

        private int _discipline_id;

        public Dialog_Add_Edit_Discipline()
        {
            #if (DEBUG)
                Console.WriteLine("Инициализация");
            #endif
            this.InitializeComponent();

            this.Text = "Добавление дисциплины";
            this.Icon = global::AppLogMySQL.ResourceApplication.AppIco;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            this.labelTitle.ForeColor = Color.FromArgb(243, 237, 210);
            this.InitializeFunction();
            this.InitializeVars();

        }

        private void InitializeFunction()
        {
            this.Load += new System.EventHandler(this.Dialog_Add_Edit_Discipline_Load);
            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                this.Invalidate();
            };
            this.CloseButton.MouseUp += this.CloseDialog;
            this.buttonCancel.MouseUp += this.CloseDialog;
        }

        private void InitializeVars()
        {
            this.query_get_d = new SQuery_Get_Disciplines();
            this.query_set_d = new SQuery_Set_Discipline(0);
            this.query_ins_d = new IQuery_Insert_Discipline();
        }

        private void FillControls()
        {
            DisciplineName.Text = string.Empty;
            DisciplineCode.Text = string.Empty;
            if (_discipline_id != -1)
            {
                this.query_set_d.Discipline = _discipline_id;
                this.query_set_d.run(Data.DataManager._connection);
                this.query_get_d.run(Data.DataManager._connection);
                DisciplineName.Text = query_get_d.dataset.Tables[0].Rows[0].ItemArray[2].ToString();
                DisciplineCode.Text = query_get_d.dataset.Tables[0].Rows[0].ItemArray[1].ToString();
            }
        }

        private void Dialog_Add_Edit_Discipline_Load(object sender, EventArgs e)
        {


        }

        private void CloseDialog(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Show(int discipline_id) {
            this._discipline_id = discipline_id;
            this.FillControls();
            this.ShowDialog();
            return true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.query_ins_d.Set_Insert_Data(DisciplineCode.Text,DisciplineName.Text);
            this.query_ins_d.run(Data.DataManager._connection);
            this.CloseDialog(sender,e);
        }
    }
}

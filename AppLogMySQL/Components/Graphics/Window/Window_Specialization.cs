using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using AppLogMySQL.Components.Graphics.Controls;
using AppLogMySQL.Components.Graphics.Dialog;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.MySql.SelectQuerys;
using AppLogMySQL.Components.MySql.InsertQuerys;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Window
{
    public partial class Window_Specialization : Form
    {
        SQuery_Set_Curriculum query_set_c;
        SQuery_Get_Curriculum query_get_c;
        SQuery_Set_Specialization query_set_s;
        SQuery_Get_Specializations query_get_s;
        IQuery_Insert_Сгurriculumb_Term iquery_ct;
        IQuery_Insert_Specialization iquery_spec;

        int setup_specialization = -1;
        int state = 0;

        private DataGridViewImageButtonEditColumn edit;
        private DataGridViewImageButtonDeleteColumn delete;

        void State_read()
        {
            buttonOK.Visible = false;
        }
        void State_edit()
        {
            buttonOK.Text = "Изменить";
        }
        void State_add()
        {
            buttonOK.Text = "OK";
        }


        public Window_Specialization()
        {
            #if (DEBUG)
                Console.WriteLine("Инициализация");
            #endif
            InitializeComponent();

            this.Text = "Добавление специальности";
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

            this.GeneralDataGrid.CellClick += new DataGridViewCellEventHandler(this.GeneralDataGrid_CellClick);
            this.GeneralDataGrid.CellMouseDown += new DataGridViewCellMouseEventHandler(this.GeneralDataGrid_CellMouseDown);
            this.GeneralDataGrid.CellMouseEnter += new DataGridViewCellEventHandler(this.GeneralDataGrid_CellMouseEnter);
            this.GeneralDataGrid.CellMouseLeave += new DataGridViewCellEventHandler(this.GeneralDataGrid_CellMouseLeave);
            this.GeneralDataGrid.CellMouseUp += new DataGridViewCellMouseEventHandler(this.GeneralDataGrid_CellMouseUp);
            this.GeneralDataGrid.CellValueChanged += new DataGridViewCellEventHandler(this.GeneralDataGrid_CellValueChanged);
            this.GeneralDataGrid.CurrentCellDirtyStateChanged += new EventHandler(this.GeneralDataGrid_CurrentCellDirtyStateChanged);
            
            this.labelTitle.MouseDown += delegate
            {
                this.labelTitle.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
                this.Invalidate();
            };
            this.CloseButton.MouseUp += delegate
            {
                this.Close();
            };
        }

        private void InitializeVars()
        {
            query_set_c = new SQuery_Set_Curriculum(-1);
            query_get_c = new SQuery_Get_Curriculum();
            query_set_s = new SQuery_Set_Specialization();
            query_get_s = new SQuery_Get_Specializations();
            iquery_ct = new IQuery_Insert_Сгurriculumb_Term();
            iquery_spec = new IQuery_Insert_Specialization();

            GeneralDataGrid.AutoGenerateColumns = false;

            this.edit = new DataGridViewImageButtonEditColumn();
            this.delete = new DataGridViewImageButtonDeleteColumn();


            this.GeneralDataGrid.Columns.Add(this.edit);
            //this.GeneralDataGrid.Columns.Add(this.delete);
        }

        private void FillControls()
        {
            #if (DEBUG)
                Console.WriteLine("Заполнение элементов");
            #endif

            query_set_s.Specialization = setup_specialization;
            query_set_s.run(DataManager._connection);
            query_set_c.run(DataManager._connection);
            query_get_c.run(DataManager._connection);
            query_get_s.run(DataManager._connection);

            if (state != 2)
            {
                GeneralDataGrid.DataSource = query_get_c.dataset.Tables[0];

                textBoxName.Text = query_get_s.dataset.Tables[0].Rows[0]["name"].ToString();
                textBoxCode.Text = query_get_s.dataset.Tables[0].Rows[0]["code"].ToString();
            }
        }

        public bool Show(int id,int type = 0){

            setup_specialization = id;
            switch (type)
            {
                case 0: State_read(); break;
                case 1: State_edit(); break;
                case 2: State_add(); break;
                default: return false;
            }
            this.state = type;
            this.FillControls();
            this.ShowDialog();
            return true;
        }
        private void Window_Load(object sender, EventArgs e)
        {
            this.FillControls();
        }



        private void SetGridButtonState(DataGridView dgv, int rowIndex, int columnIndex, PushButtonState pushButtonState)
        {
            if ((rowIndex > -1) && (columnIndex > -1))
            {
                if ((GeneralDataGrid.Columns[columnIndex].GetType().Equals(typeof(DataGridViewImageButtonEditColumn))) ||
                    (GeneralDataGrid.Columns[columnIndex].GetType().Equals(typeof(DataGridViewImageButtonDeleteColumn))))
                {
                    DataGridViewImageButtonCell buttonCell =
                        (DataGridViewImageButtonCell)dgv.
                        Rows[rowIndex].Cells[columnIndex];
                    buttonCell.Enabled = true;

                    if (buttonCell.Enabled)
                    {
                        buttonCell.ButtonState = pushButtonState;
                    }
                }
            }
        }
        private void GeneralDataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GeneralDataGrid.IsCurrentCellDirty)
            {
                GeneralDataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void GeneralDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GeneralDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetGridButtonState(GeneralDataGrid, e.RowIndex, e.ColumnIndex, PushButtonState.Pressed);
        }
        private void GeneralDataGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            SetGridButtonState(GeneralDataGrid, e.RowIndex, e.ColumnIndex, PushButtonState.Hot);
        }
        private void GeneralDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            SetGridButtonState(GeneralDataGrid, e.RowIndex, e.ColumnIndex, PushButtonState.Normal);
        }
        private void GeneralDataGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetGridButtonState(GeneralDataGrid, e.RowIndex, e.ColumnIndex, PushButtonState.Normal);
        }
        private void GeneralDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                if ((GeneralDataGrid.Columns[e.ColumnIndex].GetType().Equals(typeof(DataGridViewImageButtonEditColumn))))// ||
                //  (GeneralDataGrid.Columns[e.ColumnIndex].GetType().Equals(typeof(DataGridViewImageButtonPrintColumn))))
                {
                    DataGridViewImageButtonCell buttonCell =
                        (DataGridViewImageButtonCell)GeneralDataGrid.
                        Rows[e.RowIndex].Cells[e.ColumnIndex];

                    if (buttonCell.Enabled)
                    {
                        switch (e.ColumnIndex)
                        {
                            case 3:
                                Window.Window_Curriculumb win = new Window_Curriculumb();
                                win.Show((int)query_get_c.dataset.Tables[0].Rows[e.RowIndex]["id_curr"]);
                                FillControls();
                                // In a real application you would code some real work here.
                                //txtStatusMsg.Text = "Button Clicked: Save " + GeneralDataGrid.
                                // Rows[e.RowIndex].Cells["Text"].Value.ToString();
                                //Dialog.Dialog_Add_Edit_Discipline dialog = new Dialog.Dialog_Add_Edit_Discipline();
                                //dialog.Show((int)query_get_d.dataset.Tables[0].Rows[e.RowIndex].ItemArray[1]);
                               //this.FillControls();
                                break;

                            case 4:
                                Window.Window_Curriculumb win2 = new Window_Curriculumb();
                                win2.Show((int)query_get_c.dataset.Tables[0].Rows[e.RowIndex]["id_curr"]);
                                FillControls();
                                // In a real application you would code some real work here.
                                // txtStatusMsg.Text = "Button Clicked: Print " + GeneralDataGrid.
                                //Rows[e.RowIndex].Cells["Text"].Value.ToString();
                                break;
                        }
                    }
                    else
                    {
                        //txtStatusMsg.Text = "Disabled button clicked. No action taken.";
                    }
                }
            }
        }

        private class DataGridViewImageButtonEditColumn : DataGridViewButtonColumn
        {
            public class DataGridViewImageButtonEditCell : DataGridViewImageButtonCell
            {
                public override void LoadImages()
                {
                    _buttonImageNormal = AppLogMySQL.ResourceApplication.Edit;

                    _buttonImageDisabled = AppLogMySQL.ResourceApplication.Edit;
                    _buttonImagePressed = AppLogMySQL.ResourceApplication.Edit;
                    _buttonImageHot = AppLogMySQL.ResourceApplication.Edit;
                    this.ButtonState = PushButtonState.Normal;
                }
            }

            public DataGridViewImageButtonEditColumn()
            {
                this.CellTemplate = new DataGridViewImageButtonEditCell();
                this.Width = 23;
                this.Resizable = DataGridViewTriState.False;
                this.Name = "EditButtons";
                this.HeaderText = "";
                this.ReadOnly = false;
            }
        }
        private class DataGridViewImageButtonDeleteColumn : DataGridViewButtonColumn
        {
            public class DataGridViewImageButtonDeleteCell : DataGridViewImageButtonCell
            {
                public override void LoadImages()
                {
                    _buttonImageNormal = AppLogMySQL.ResourceApplication.Delete;

                    _buttonImageDisabled = AppLogMySQL.ResourceApplication.Delete;
                    _buttonImagePressed = AppLogMySQL.ResourceApplication.Delete;
                    _buttonImageHot = AppLogMySQL.ResourceApplication.Delete;
                }
            }
            public DataGridViewImageButtonDeleteColumn()
            {
                this.CellTemplate = new DataGridViewImageButtonDeleteCell();
                this.Width = 23;
                this.Resizable = DataGridViewTriState.False;
                this.Name = "DeleteButtons";
                this.HeaderText = "";
                this.ReadOnly = false;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            iquery_ct.run(DataManager._connection);
            FillControls();
        }

        private void Window_Specialization_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.query_set_s.Specialization = setup_specialization;
            this.query_set_s.run(DataManager._connection);
            this.iquery_spec.Set_Insert_Data(textBoxCode.Text, textBoxName.Text);
            this.iquery_spec.run(Data.DataManager._connection);
            this.Close();
        }

    }
}

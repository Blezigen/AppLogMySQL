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

namespace AppLogMySQL.Components.Graphics.Window
{
    public partial class Window_Disciplines : Form
    {
        private SQuery_Get_Disciplines query_get_d;
        private SQuery_Set_Discipline query_set_d;
        private DataTable disciplines_data;
        private DataGridViewImageButtonEditColumn edit;
        private DataGridViewImageButtonDeleteColumn delete;

        public Window_Disciplines()
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
                Invalidate();
            };
            this.CloseButton.MouseUp += delegate
            {
                this.Close();
            };
        }
        private void InitializeVars()
        {
            
            this.query_get_d = new MySql.SelectQuerys.SQuery_Get_Disciplines();
            this.query_set_d = new SQuery_Set_Discipline(-1);
            this.disciplines_data = new DataTable();

            this.edit = new DataGridViewImageButtonEditColumn();
            this.delete = new DataGridViewImageButtonDeleteColumn();


            this.GeneralDataGrid.Columns.Add(this.edit);
            this.GeneralDataGrid.Columns.Add(this.delete);

        }


        private void FillControls()
        {
            #if (DEBUG)
                        Console.WriteLine("Заполнение элементов");
            #endif
            this.query_set_d.run(Data.DataManager._connection);
            this.GeneralDataGrid.AutoGenerateColumns = false;
            this.query_get_d.run(Data.DataManager._connection);
            this.disciplines_data = this.query_get_d.dataset.Tables[0];
            this.GeneralDataGrid.DataSource = this.disciplines_data;
        }

        private void Window_Disciplines_Load(object sender, EventArgs e)
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
                            case 2:
                                // In a real application you would code some real work here.
                                //txtStatusMsg.Text = "Button Clicked: Save " + GeneralDataGrid.
                                   // Rows[e.RowIndex].Cells["Text"].Value.ToString();
                                 Dialog.Dialog_Add_Edit_Discipline dialog = new Dialog.Dialog_Add_Edit_Discipline();
                                 dialog.Show((int)query_get_d.dataset.Tables[0].Rows[e.RowIndex].ItemArray[1]);
                                 this.FillControls();
                                 break;

                            case 3:
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

        public class DataGridViewImageButtonEditColumn : DataGridViewButtonColumn
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
        public class DataGridViewImageButtonDeleteColumn : DataGridViewButtonColumn
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
            Dialog.Dialog_Add_Edit_Discipline dialog = new Dialog.Dialog_Add_Edit_Discipline();
            dialog.Show(-1);
            this.FillControls();
        }
    }
}

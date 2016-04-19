using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.MySql.SelectQuerys;
using System.Windows.Forms.VisualStyles;
using System.IO;
using AppLogMySQL.Components.Graphics.Controls;

namespace AppLogMySQL.Components.Graphics.States.SubStates
{
    public partial class SubStates_Disciplines : UserControl
    {
        //Кастомная колонка
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
        

        SQuery_Get_Disciplines query_d_all;
        DataTable disciplines_data;
        public SubStates_Disciplines()
        {
            InitializeComponent();
            #if (DEBUG)
                        Console.WriteLine("Инициализация");
            #endif
            query_d_all = new MySql.SelectQuerys.SQuery_Get_Disciplines();
            disciplines_data = new DataTable();

            DataGridViewImageButtonEditColumn edit = new DataGridViewImageButtonEditColumn();
            DataGridViewImageButtonDeleteColumn delete = new DataGridViewImageButtonDeleteColumn();

            GeneralDataGrid.Columns.Add(edit);
            GeneralDataGrid.Columns.Add(delete);
        }

        void dataGridView1_CurrentCellDirtyStateChanged(object sender,
            EventArgs e)
        {
            if (GeneralDataGrid.IsCurrentCellDirty)
            {
                GeneralDataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        public void dataGridView1_CellValueChanged(object sender,
            DataGridViewCellEventArgs e)
        {
         
        }

        // If the mouse is pressed, set the PushButtonState = Pressed.
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetGridButtonState(GeneralDataGrid, e.RowIndex, e.ColumnIndex, PushButtonState.Pressed);
        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            SetGridButtonState(GeneralDataGrid, e.RowIndex, e.ColumnIndex, PushButtonState.Hot);
        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            SetGridButtonState(GeneralDataGrid, e.RowIndex, e.ColumnIndex, PushButtonState.Normal);
        }
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetGridButtonState(GeneralDataGrid, e.RowIndex, e.ColumnIndex, PushButtonState.Normal);
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                            case 0:
                                // In a real application you would code some real work here.
                                //txtStatusMsg.Text = "Button Clicked: Save " + GeneralDataGrid.
                                   // Rows[e.RowIndex].Cells["Text"].Value.ToString();
                                break;

                            case 1:
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AppLogMySQL.Components.Data.DataManager.substate_states.state_Change("UserProfile");
        }

        private void SubStates_Disciplines_Load(object sender, EventArgs e)
        {
            #if (DEBUG)
                Console.WriteLine("Заполнение элементов");
            #endif
            GeneralDataGrid.AutoGenerateColumns = false;
            query_d_all.run(Data.DataManager._connection);
            disciplines_data = query_d_all.dataset.Tables[0];
            GeneralDataGrid.DataSource = disciplines_data;
            DataGridViewButtonCell s = new DataGridViewButtonCell();
        }

    }
}


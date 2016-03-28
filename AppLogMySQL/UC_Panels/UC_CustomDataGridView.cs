using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Resources;
using System.Data;

namespace AppLogMySQL.UC_Panels
{
    [Designer(typeof(CustomDataGridViewDesigner))]
    public partial class UC_CustomDataGridView : DataGridView
    {
        DataTable dt;
        DataTable kl = new DataTable();
        public CDGV_Controls.CDGV_AddDate dateAdder;
        private int LeftNoSelectableColumn = 1;
        private int RightNoSelectableColumn = 2;
        private int CountColumnExp = 2;

        private UC_TransparentControl ArrowTop;
        private UC_TransparentControl ArrowLeft;
        private UC_TransparentControl ArrowRight;
        private UC_TransparentControl ArrowBottom;

        public int LeftIndexDisableColumn
        {
            get
            {
                return this.LeftNoSelectableColumn;
            }
            set
            {
                this.LeftNoSelectableColumn = value;
                this.Invalidate();
            }
        }
        public int RightIndexDisableColumn
        {
            get
            {
                return this.RightNoSelectableColumn;
            }
            set
            {
                this.RightNoSelectableColumn = value;
            }
        }
        public UC_CustomDataGridView()
        {
            this.ArrowTop = new UC_TransparentControl();
            this.ArrowLeft = new UC_TransparentControl();
            this.ArrowRight = new UC_TransparentControl();
            this.ArrowBottom = new UC_TransparentControl();
            this.dateAdder = new CDGV_Controls.CDGV_AddDate();
            this.SuspendLayout();
            this.Name = "CustomDataGridView";
            
            #region Свойства Grid Coursor
            #region Часть Курсора ArrowTop
            // 
            // ArrowTop
            // 
            this.ArrowTop.BackColor = System.Drawing.Color.Transparent;
            //this.ArrowTop.BackImage = ((System.Drawing.Image)(ResourceImages.ArrowTop));
            this.ArrowTop.FillColor = System.Drawing.Color.Transparent;
            this.ArrowTop.GlassColor = System.Drawing.Color.Transparent;
            this.ArrowTop.GlassMode = true;
            this.ArrowTop.LineWidth = 0;
            this.ArrowTop.Location = new System.Drawing.Point(0, 0);
            this.ArrowTop.Name = "ArrowTop";
            this.ArrowTop.Opacity = 100;
            this.ArrowTop.Size = new System.Drawing.Size(31, 29);
            this.ArrowTop.TabIndex = 1;
            this.ArrowTop.TranspKey = System.Drawing.Color.White;
            this.ArrowTop.Visible = false;
            this.ArrowTop.Click += new System.EventHandler(this.ArrowTop_Click);
            #endregion

            #region Часть Курсора ArrowLeft
            // 
            // ArrowLeft
            // 
            this.ArrowLeft.BackColor = System.Drawing.Color.Transparent;
            //this.ArrowLeft.BackImage = ((System.Drawing.Image)(ResourceImages.ArrowLeft));
            this.ArrowLeft.FillColor = System.Drawing.Color.Transparent;
            this.ArrowLeft.GlassColor = System.Drawing.Color.Transparent;
            this.ArrowLeft.GlassMode = true;
            this.ArrowLeft.LineWidth = 0;
            this.ArrowLeft.Location = new System.Drawing.Point(0, 0);
            this.ArrowLeft.Name = "ArrowLeft";
            this.ArrowLeft.Opacity = 100;
            this.ArrowLeft.Size = new System.Drawing.Size(31, 29);
            this.ArrowLeft.TabIndex = 2;
            this.ArrowLeft.TranspKey = System.Drawing.Color.White;
            this.ArrowLeft.Visible = false;
            this.ArrowLeft.Click += new System.EventHandler(this.ArrowLeft_Click);
            #endregion

            #region Часть Курсора ArrowRight
            // 
            // ArrowRight
            // 
            this.ArrowRight.BackColor = System.Drawing.Color.Transparent;
            //this.ArrowRight.BackImage = ((System.Drawing.Image)(ResourceImages.ArrowRight));
            this.ArrowRight.FillColor = System.Drawing.Color.Transparent;
            this.ArrowRight.GlassColor = System.Drawing.Color.Transparent;
            this.ArrowRight.GlassMode = true;
            this.ArrowRight.LineWidth = 0;
            this.ArrowRight.Location = new System.Drawing.Point(0, 0);
            this.ArrowRight.Name = "ArrowRight";
            this.ArrowRight.Opacity = 100;
            this.ArrowRight.Size = new System.Drawing.Size(31, 29);
            this.ArrowRight.TabIndex = 3;
            this.ArrowRight.TranspKey = System.Drawing.Color.White;
            this.ArrowRight.Visible = false;
            this.ArrowRight.Click += new System.EventHandler(this.ArrowRight_Click);
            #endregion

            #region Часть Курсора ArrowBottom
            // 
            // ArrowBottom
            // 
            this.ArrowBottom.BackColor = System.Drawing.Color.Transparent;
            //this.ArrowBottom.BackImage = ((System.Drawing.Image)(ResourceImages.ArrowBottom));
            this.ArrowBottom.FillColor = System.Drawing.Color.Transparent;
            this.ArrowBottom.GlassColor = System.Drawing.Color.Transparent;
            this.ArrowBottom.GlassMode = true;
            this.ArrowBottom.LineWidth = 0;
            this.ArrowBottom.Location = new System.Drawing.Point(0, 0);
            this.ArrowBottom.Name = "ArrowBottom";
            this.ArrowBottom.Opacity = 100;
            this.ArrowBottom.Size = new System.Drawing.Size(31, 29);
            this.ArrowBottom.TabIndex = 4;
            this.ArrowBottom.TranspKey = System.Drawing.Color.White;
            this.ArrowBottom.Visible = false;
            this.ArrowBottom.Click += new System.EventHandler(this.ArrowBottom_Click);
            #endregion
            #endregion

            this.Controls.Add(this.dateAdder);
            this.Controls.Add(this.ArrowBottom);
            this.Controls.Add(this.ArrowTop);
            this.Controls.Add(this.ArrowLeft);
            this.Controls.Add(this.ArrowRight);
            
            //this.Font = new Font("Proxima Nova Rg", 10f, FontStyle.Regular);
            this.ResumeLayout(false);
            dateAdder.Visible = false;
            dateAdder.buttonOK.Click += delegate
            {
                addDate();
                Invalidate();
            };
        }


        public void DisplayDataInGrid(System.Data.DataTable table)
        {
            this.Font = new Font("Proxima Nova Rg", 10f, FontStyle.Regular);
            DataGridViewTextBoxColumn ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColumnAddLogValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ColumnInfinity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            #region Добавление колонок в CustomDataGridView
            //
            // Column Number
            //
            ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnNumber.FillWeight = 1F;
            ColumnNumber.Frozen = true;
            ColumnNumber.HeaderText = "№";
            ColumnNumber.MinimumWidth = 30;
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ColumnNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColumnNumber.Width = 30;
            ColumnNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // Колонка "ФИО"
            // 
            ColumnFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnFullName.FillWeight = 300F;
            ColumnFullName.Frozen = true;
            ColumnFullName.HeaderText = "Полное Имя";
            ColumnFullName.MinimumWidth = 300;
            ColumnFullName.Name = "ColumnFullName";
            
            ColumnFullName.ReadOnly = true;
            ColumnFullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ColumnFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColumnFullName.Width = 300;
            // 
            // Колонка для добаления колонки оценок
            // 
            ColumnAddLogValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnAddLogValue.Frozen = false;
            ColumnAddLogValue.FillWeight = 31F;
            ColumnAddLogValue.HeaderText = "+";
            ColumnAddLogValue.MinimumWidth = 30;
            ColumnAddLogValue.Name = "ColumnAddLogValue";
            ColumnAddLogValue.ReadOnly = true;
            ColumnAddLogValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ColumnAddLogValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColumnAddLogValue.Width = 30;
            // 
            // InfinityColumn
            // 
            ColumnInfinity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ColumnInfinity.DividerWidth = 2;
            ColumnInfinity.FillWeight = 2F;
            ColumnInfinity.HeaderText = "";
            ColumnInfinity.MinimumWidth = 2;
            ColumnInfinity.Name = "ColumnInfinity";
            ColumnInfinity.ReadOnly = true;
            ColumnInfinity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ColumnInfinity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            #endregion

            dt = table;
            this.Rows.Clear();
            this.Columns.Clear();
            this.Columns.Add(ColumnNumber);
            this.Columns.Add(ColumnFullName);

            foreach (System.Data.DataRow row in DataCollection.queryGetStudentsIntoGroupData().Rows)
            {
                this.Rows.Add(row[0], row["full_name"]);
            }

            foreach (System.Data.DataRow row in table.Rows)
            {
                if (!this.Columns.Contains("Day_" + row["logDay"].ToString()))
                {
                    addColumn(Int32.Parse(row["logDay"].ToString()));
                }

                foreach (DataGridViewRow rowsa in this.Rows)
                {
                    if (rowsa.Cells[0].Value != null)
                    {
                        if (rowsa.Cells[0].Value.ToString().Contains(row[0].ToString()))
                        {
                            break;
                        }
                    }
                    else
                    {
                        this.Rows.Add(row[0], row["full_name"]);
                        break;
                    }
                }

                foreach (DataGridViewRow rowsa in this.Rows)
                {
                    if (rowsa.Cells[0].Value != null)
                    {
                        if (rowsa.Cells[0].Value.ToString().Contains(row[0].ToString()))
                        {
                            rowsa.Cells["Day_" + row["logDay"]].Value = row["log_day_value"].ToString();
                            break;
                        }
                    }

                }
            }
            this.Columns.Add(ColumnAddLogValue);
            this.Columns.Add(ColumnInfinity);
            //this.Columns["ColumnAddLogValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;*/
        }

        void refreshGrid() { 
            
        }

        void addDate()
        {
            if (!DataCollection.log_days.Columns.Contains(dateAdder.dateTimePicker1.Value.ToString("dd"))) {
                DataCollection.log_days.Columns.Add(dateAdder.dateTimePicker1.Value.ToString("dd"));
                addColumn(Int32.Parse(dateAdder.dateTimePicker1.Value.ToString("dd")));
            }
            else
            {
                MessageBox.Show("Такая дата уже существует!");
            }
        }
        void addDateValue(string iColumn, int iRow, string eval)
        {
            DataCollection.log_days.Rows[iRow][iColumn] = eval;
            //MessageBox.Show(dateAdder.dateTimePicker1.Value.ToString("dd"));
        }

        public void addColumn(int c)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Day_" + (c).ToString();
            column.MinimumWidth = 30;
            column.Width = 30;
            //column.DefaultCellStyle.BackColor = Color.FromArgb(0,0,0);
            column.Resizable = DataGridViewTriState.False;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DisplayIndex = CountColumnExp;
            column.HeaderText = (c).ToString();
            column.Visible = true;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Columns.Add(column);
            CountColumnExp++;

        }
        private void changePositionCoursor(int CIndex, int RIndex)
        {
            Rectangle CellRect = GetCellDisplayRectangle(CIndex, RIndex, false);
            ArrowLeft.Visible = !(Columns[CIndex].DisplayIndex <= LeftIndexDisableColumn);
            ArrowRight.Visible = !(Columns[CIndex].DisplayIndex == ColumnCount - RightIndexDisableColumn - 1);
            ArrowTop.Visible = !(RIndex < 1);
            ////////////////////
            if (Columns[CIndex].DisplayIndex >= LeftIndexDisableColumn && Columns[CIndex].DisplayIndex < ColumnCount - RightIndexDisableColumn)
            {
                ArrowLeft.Location = new Point(CellRect.X - ArrowLeft.Width, CellRect.Y - ArrowLeft.Height / 2 + CellRect.Height / 2);
                ArrowRight.Location = new Point(CellRect.X + CellRect.Width, ArrowLeft.Top);
                ArrowTop.Location = new Point(CellRect.X - ArrowTop.Width / 2 + CellRect.Width / 2, CellRect.Y - ArrowTop.Height);
                ArrowBottom.Location = new Point(CellRect.X - ArrowBottom.Width / 2 + CellRect.Width / 2, CellRect.Y + CellRect.Height);
            }

        }
        protected override void SetSelectedCellCore(int columnIndex, int rowIndex, bool selected)
        {

            if (Columns[columnIndex].DisplayIndex < LeftNoSelectableColumn & LeftNoSelectableColumn != 0)
            {
                columnIndex = LeftNoSelectableColumn;
                changePositionCoursor(columnIndex, rowIndex);
                base.SetSelectedCellCore(columnIndex, rowIndex, selected);
            }
            else if (Columns[columnIndex].DisplayIndex > ColumnCount-1 - RightNoSelectableColumn & RightNoSelectableColumn != 0)
            {
                columnIndex = ColumnCount-1 - RightNoSelectableColumn;
                changePositionCoursor(columnIndex, rowIndex);
                base.SetSelectedCellCore(columnIndex, rowIndex, selected);
            }
            else
            {
                changePositionCoursor(columnIndex, rowIndex);
                base.SetSelectedCellCore(columnIndex, rowIndex, selected);
            }
            this.Invalidate();
        }
        protected override void OnCellMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Columns["ColumnAddLogValue"].Index & e.RowIndex == -1)
            {
                Rectangle CellRect = GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                dateAdder.Visible = true;
                dateAdder.Location = new Point(CellRect.Location.X+e.Location.X-dateAdder.Width, CellRect.Location.Y+e.Location.Y);
                //addColumn(Columns["ColumnAddLogValue"].DisplayIndex);
                //Columns["ColumnAddLogValue"].DisplayIndex++;
                //Columns["ColumnInfinity"].DisplayIndex++;
            }
            this.Invalidate();
            base.OnCellMouseClick(e);

        }
        protected override void OnCellMouseDown(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseDown(e);
            this.Invalidate();
        }


        protected override void OnCellMouseDoubleClick(DataGridViewCellMouseEventArgs e)
        {
            if (Columns[e.ColumnIndex].DisplayIndex > LeftNoSelectableColumn - 1 && Columns[e.ColumnIndex].DisplayIndex <= ColumnCount-1 - RightNoSelectableColumn)
            {
                base.OnCellMouseDoubleClick(e);
                AddLogValue p = new AddLogValue();
                Rectangle CellRect = GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                p.Location = new Point(CellRect.Location.X + e.Location.X - p.Width, CellRect.Location.Y + e.Location.Y);
                p.ShowDialog();
            }
            this.Invalidate();
        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) && (CurrentCell.OwningColumn.DisplayIndex > LeftNoSelectableColumn))
            {
                base.OnKeyDown(e);
            }
            if ((e.KeyCode == Keys.Right) && (CurrentCell.OwningColumn.DisplayIndex < ColumnCount-1 - RightNoSelectableColumn ))
            {
                base.OnKeyDown(e);
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                base.OnKeyDown(e);
            }
            this.Invalidate();
        }
        private void ArrowTop_Click(object sender, EventArgs e)
        {
            KeyEventArgs n = new KeyEventArgs(Keys.Up);
            this.OnKeyDown(n);
        }
        private void ArrowRight_Click(object sender, EventArgs e)
        {
            KeyEventArgs n = new KeyEventArgs(Keys.Right);
            this.OnKeyDown(n);
        }
        private void ArrowLeft_Click(object sender, EventArgs e)
        {
            KeyEventArgs n = new KeyEventArgs(Keys.Left);
            this.OnKeyDown(n);
        }
        private void ArrowBottom_Click(object sender, EventArgs e)
        {
            KeyEventArgs n = new KeyEventArgs(Keys.Down);
            this.OnKeyDown(n);
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_CustomDataGridView
            // 
            this.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UC_CustomDataGridView_CellValueChanged);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void UC_CustomDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            addDateValue(this.Columns[e.ColumnIndex].Name,e.RowIndex,this[e.ColumnIndex,e.RowIndex].ToString());
        }
    }
    internal class CustomDataGridViewDesigner : ControlDesigner
    {
        private UC_CustomDataGridView control;

        protected override void OnMouseDragBegin(int x, int y)
        {
            base.OnMouseDragBegin(x, y);
            control = (UC_CustomDataGridView)(this.Control);
        }
        protected override void OnMouseLeave()
        {
            base.OnMouseLeave();
            control = (UC_CustomDataGridView)(this.Control);
        }
    }
}

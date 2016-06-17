using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLogMySQL.Components.MySql.InsertQuerys;
using AppLogMySQL.Components.MySql.SetQuerys;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.Dialog
{
    public partial class Dialog_SAE_Log_Value : Form
    {
        private int log_value;
        private Color selectedColor;
        IQuery_Insert_Log_Value iquery_log_value;
        SQuery_Set_Discipline query_set_discipline;
        SQuery_Set_Student query_set_student;
        SQuery_Set_Log_Month query_set_month;
        SQuery_Set_Log_Year query_set_year;

        public Dialog_SAE_Log_Value()
        {
            this.InitializeComponent();

            this.Text = "Добаление оценки";
            this.Icon = global::AppLogMySQL.ResourceApplication.AppIco;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.labelTitle.Font = Components.Data.DataManager.PROXIMA_NOVA_9R;
            this.labelTitle.ForeColor = Color.FromArgb(243, 237, 210);
            this.InitializeFunction();
            this.InitializeVars();
        }
        
        
        
        private void InitializeVars()
        {
            log_value = 5;
            selectedColor = new Color();
            selectedColor = Color.FromArgb(207,152,67);
            iquery_log_value = new IQuery_Insert_Log_Value();
            query_set_discipline = new SQuery_Set_Discipline(-1);
            query_set_student = new SQuery_Set_Student();
            query_set_year = new SQuery_Set_Log_Year();
            query_set_month = new SQuery_Set_Log_Month();
        }

        private void InitializeFunction()
        {
            //this.Load += new System.EventHandler(this.Window_Load);
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

        private void FillControls()
        {

        }

        private void valChange(int val) {

            buttonValue1.BackColor = System.Drawing.SystemColors.Control;
            buttonValue2.BackColor = System.Drawing.SystemColors.Control;
            buttonValue3.BackColor = System.Drawing.SystemColors.Control;
            buttonValue4.BackColor = System.Drawing.SystemColors.Control;
            buttonValue5.BackColor = System.Drawing.SystemColors.Control;
            buttonN.BackColor = System.Drawing.SystemColors.Control;
            buttonY.BackColor = System.Drawing.SystemColors.Control;
            buttonB.BackColor = System.Drawing.SystemColors.Control;

            log_value = val;

            switch (val)
            {
                case 1: buttonValue1.BackColor = selectedColor; this.iquery_log_value.Value = Log_Val.Val_1; break;
                case 2: buttonValue2.BackColor = selectedColor; this.iquery_log_value.Value = Log_Val.Val_2; break;
                case 3: buttonValue3.BackColor = selectedColor; this.iquery_log_value.Value = Log_Val.Val_3; break;
                case 4: buttonValue4.BackColor = selectedColor; this.iquery_log_value.Value = Log_Val.Val_4; break;
                case 5: buttonValue5.BackColor = selectedColor; this.iquery_log_value.Value = Log_Val.Val_5; break;
                case 7: buttonN.BackColor = selectedColor; buttonY.BackColor = selectedColor; this.iquery_log_value.Value = Log_Val.Val_tht; break;
                case 8: buttonN.BackColor = selectedColor; buttonB.BackColor = selectedColor; this.iquery_log_value.Value = Log_Val.Val_ill; break;
                default: buttonN.BackColor = selectedColor;  this.iquery_log_value.Value = Log_Val.Val_not; break;
            }
        }
        public bool Show(int student, int disp ,int year,int month, int day ,string value = "5") {
            this.groupBox2.Visible = false; 
            this.groupBox1.Visible = true;

            this.query_set_student.Student = student;
            this.query_set_discipline.Discipline = disp;
            this.query_set_month.Month = month;
            this.query_set_year.Year = year;
            this.iquery_log_value.Day = day;


            switch (value)
            {
                case "1": valChange(1); break;
                case "2": valChange(2); break;
                case "3": valChange(3); break;
                case "4": valChange(4); break;
                case "5": valChange(5); break;
                case "Б": valChange(8); this.groupBox2.Visible = true; break;
                case "Н": valChange(6); this.groupBox2.Visible = true; break;
                case "У": valChange(7); this.groupBox2.Visible = true; break;
                default: break;
            }
            this.FillControls();
            this.ShowDialog();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = !this.groupBox2.Visible;
            if (groupBox2.Visible)
                buttonN.BackColor = selectedColor;
            else
                buttonN.BackColor = System.Drawing.SystemColors.Control;
            valChange(9);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            query_set_year.run(DataManager._connection);
            query_set_month.run(DataManager._connection);
            query_set_student.run(DataManager._connection);
            query_set_discipline.run(DataManager._connection);
            iquery_log_value.run(DataManager._connection);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonValue1_Click(object sender, EventArgs e)
        {
            valChange(1);
        }

        private void buttonValue2_Click(object sender, EventArgs e)
        {
            valChange(2);
        }

        private void buttonValue3_Click(object sender, EventArgs e)
        {
            valChange(3);
        }

        private void buttonValue4_Click(object sender, EventArgs e)
        {
            valChange(4);
        }

        private void buttonValue5_Click(object sender, EventArgs e)
        {
            valChange(5);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            valChange(7);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            valChange(8);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            query_set_year.run(DataManager._connection);
            query_set_month.run(DataManager._connection);
            query_set_student.run(DataManager._connection);
            query_set_discipline.run(DataManager._connection);
            iquery_log_value.Value = Log_Val.Val_clear;
            iquery_log_value.run(DataManager._connection);

            Close();
        }

    }
}

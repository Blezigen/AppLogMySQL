namespace AppLogMySQL.Components.Graphics.States.SubStates
{
    partial class SubStates_Curiculumbs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SchedulesDayData1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesDayData1)).BeginInit();
            this.SuspendLayout();
            // 
            // SchedulesDayData1
            // 
            this.SchedulesDayData1.AllowUserToAddRows = false;
            this.SchedulesDayData1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchedulesDayData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SchedulesDayData1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Discipline});
            this.SchedulesDayData1.Location = new System.Drawing.Point(21, 30);
            this.SchedulesDayData1.MultiSelect = false;
            this.SchedulesDayData1.Name = "SchedulesDayData1";
            this.SchedulesDayData1.RowHeadersVisible = false;
            this.SchedulesDayData1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SchedulesDayData1.RowTemplate.Height = 23;
            this.SchedulesDayData1.Size = new System.Drawing.Size(845, 578);
            this.SchedulesDayData1.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.FillWeight = 30F;
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.Width = 30;
            // 
            // Discipline
            // 
            this.Discipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discipline.HeaderText = "Предмет";
            this.Discipline.Name = "Discipline";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(21, 3);
            this.comboBoxGroups.MaxDropDownItems = 100;
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(240, 21);
            this.comboBoxGroups.TabIndex = 13;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(18, 611);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "«";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SubStates_Curiculumbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.SchedulesDayData1);
            this.Controls.Add(this.comboBoxGroups);
            this.Name = "SubStates_Curiculumbs";
            this.Size = new System.Drawing.Size(869, 611);
            this.Load += new System.EventHandler(this.SubStates_Schedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesDayData1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SchedulesDayData1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discipline;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Button buttonBack;
    }
}

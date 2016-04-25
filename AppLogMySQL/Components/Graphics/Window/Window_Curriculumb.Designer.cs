namespace AppLogMySQL.Components.Graphics.Window
{
    partial class Window_Curriculumb
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.GeneralDataGrid = new System.Windows.Forms.DataGridView();
            this.LabelStudent = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.logoPicture = new AppLogMySQL.UC_Panels.UC_TransparentControl();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lectures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkHomeEXP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credits = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.exams = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDataGrid)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.Image = global::AppLogMySQL.ResourceApplication.Add15x15;
            this.ButtonAdd.Location = new System.Drawing.Point(621, 33);
            this.ButtonAdd.MaximumSize = new System.Drawing.Size(21, 21);
            this.ButtonAdd.MinimumSize = new System.Drawing.Size(21, 21);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(21, 21);
            this.ButtonAdd.TabIndex = 116;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // GeneralDataGrid
            // 
            this.GeneralDataGrid.AllowUserToAddRows = false;
            this.GeneralDataGrid.AllowUserToDeleteRows = false;
            this.GeneralDataGrid.AllowUserToResizeColumns = false;
            this.GeneralDataGrid.AllowUserToResizeRows = false;
            this.GeneralDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GeneralDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneralDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GeneralDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Lectures,
            this.WorkHomeEXP,
            this.SelfWork,
            this.credits,
            this.exams});
            this.GeneralDataGrid.Location = new System.Drawing.Point(2, 55);
            this.GeneralDataGrid.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.GeneralDataGrid.MultiSelect = false;
            this.GeneralDataGrid.Name = "GeneralDataGrid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Proxima Nova Rg", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GeneralDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GeneralDataGrid.RowHeadersVisible = false;
            this.GeneralDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GeneralDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GeneralDataGrid.RowTemplate.Height = 23;
            this.GeneralDataGrid.Size = new System.Drawing.Size(640, 300);
            this.GeneralDataGrid.TabIndex = 115;
            // 
            // LabelStudent
            // 
            this.LabelStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelStudent.Location = new System.Drawing.Point(51, 32);
            this.LabelStudent.Margin = new System.Windows.Forms.Padding(0, 6, 0, 1);
            this.LabelStudent.Name = "LabelStudent";
            this.LabelStudent.Size = new System.Drawing.Size(560, 20);
            this.LabelStudent.TabIndex = 117;
            this.LabelStudent.Text = "Настройте семестр {0}:";
            this.LabelStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(159)))), ((int)(((byte)(141)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.CloseButton);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(644, 30);
            this.panelTitle.TabIndex = 130;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.labelTitle.Location = new System.Drawing.Point(47, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(564, 24);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Симестр";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Image = global::AppLogMySQL.ResourceApplication.Close;
            this.CloseButton.Location = new System.Drawing.Point(617, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(568, 356);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 131;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.BackImage = global::AppLogMySQL.ResourceApplication.EditLogo;
            this.logoPicture.FillColor = System.Drawing.Color.White;
            this.logoPicture.GlassColor = System.Drawing.Color.Transparent;
            this.logoPicture.GlassMode = true;
            this.logoPicture.LineWidth = 0;
            this.logoPicture.Location = new System.Drawing.Point(0, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Opacity = 100;
            this.logoPicture.Size = new System.Drawing.Size(44, 47);
            this.logoPicture.TabIndex = 129;
            this.logoPicture.TranspKey = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numberx";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "discipline";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lectures
            // 
            this.Lectures.DataPropertyName = "l";
            this.Lectures.HeaderText = "Лекции";
            this.Lectures.Name = "Lectures";
            this.Lectures.Width = 65;
            // 
            // WorkHomeEXP
            // 
            this.WorkHomeEXP.DataPropertyName = "w";
            this.WorkHomeEXP.HeaderText = "Дом.Раб";
            this.WorkHomeEXP.Name = "WorkHomeEXP";
            this.WorkHomeEXP.Width = 65;
            // 
            // SelfWork
            // 
            this.SelfWork.DataPropertyName = "s";
            this.SelfWork.HeaderText = "Сам.Раб";
            this.SelfWork.Name = "SelfWork";
            this.SelfWork.Width = 65;
            // 
            // credits
            // 
            this.credits.DataPropertyName = "c";
            this.credits.FalseValue = "0";
            this.credits.HeaderText = "Зачет";
            this.credits.MinimumWidth = 75;
            this.credits.Name = "credits";
            this.credits.TrueValue = "1";
            this.credits.Width = 75;
            // 
            // exams
            // 
            this.exams.DataPropertyName = "e";
            this.exams.FalseValue = "0";
            this.exams.HeaderText = "Экзамен";
            this.exams.MinimumWidth = 75;
            this.exams.Name = "exams";
            this.exams.TrueValue = "1";
            this.exams.Width = 75;
            // 
            // Window_Curriculumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 380);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.LabelStudent);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.GeneralDataGrid);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window_Curriculumb";
            this.Text = "Curriculumb";
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDataGrid)).EndInit();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.DataGridView GeneralDataGrid;
        private System.Windows.Forms.Label LabelStudent;
        private UC_Panels.UC_TransparentControl logoPicture;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lectures;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkHomeEXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelfWork;
        private System.Windows.Forms.DataGridViewCheckBoxColumn credits;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exams;
    }
}
namespace AppLogMySQL.ControllPanel.UserControls
{
    partial class CP_SelectedLog
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
            this.comboBoxTypeValues = new System.Windows.Forms.ComboBox();
            this.easyEdit = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.Tab3 = new System.Windows.Forms.TabPage();
            this.Tab4 = new System.Windows.Forms.TabPage();
            this.Tab5 = new System.Windows.Forms.TabPage();
            this.Tab6 = new System.Windows.Forms.TabPage();
            this.Tab7 = new System.Windows.Forms.TabPage();
            this.Tab8 = new System.Windows.Forms.TabPage();
            this.Tab9 = new System.Windows.Forms.TabPage();
            this.Tab10 = new System.Windows.Forms.TabPage();
            this.Tab11 = new System.Windows.Forms.TabPage();
            this.LabelTitleLog = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.buttonDisciplina = new System.Windows.Forms.Button();
            this.Grid = new AppLogMySQL.UC_Panels.UC_CustomDataGridView();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTypeValues
            // 
            this.comboBoxTypeValues.Font = new System.Drawing.Font("Proxima Nova Rg", 10F);
            this.comboBoxTypeValues.FormattingEnabled = true;
            this.comboBoxTypeValues.IntegralHeight = false;
            this.comboBoxTypeValues.ItemHeight = 16;
            this.comboBoxTypeValues.Location = new System.Drawing.Point(232, 18);
            this.comboBoxTypeValues.Name = "comboBoxTypeValues";
            this.comboBoxTypeValues.Size = new System.Drawing.Size(212, 24);
            this.comboBoxTypeValues.TabIndex = 5;
            this.comboBoxTypeValues.Text = "Показать: Все";
            this.comboBoxTypeValues.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeValues_SelectedIndexChanged);
            // 
            // easyEdit
            // 
            this.easyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.easyEdit.AutoSize = true;
            this.easyEdit.Checked = true;
            this.easyEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.easyEdit.Enabled = false;
            this.easyEdit.Location = new System.Drawing.Point(25, 470);
            this.easyEdit.Name = "easyEdit";
            this.easyEdit.Size = new System.Drawing.Size(198, 17);
            this.easyEdit.TabIndex = 11;
            this.easyEdit.Text = "Режим быстрого редактирования";
            this.easyEdit.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.Tab1);
            this.tabControl1.Controls.Add(this.Tab2);
            this.tabControl1.Controls.Add(this.Tab3);
            this.tabControl1.Controls.Add(this.Tab4);
            this.tabControl1.Controls.Add(this.Tab5);
            this.tabControl1.Controls.Add(this.Tab6);
            this.tabControl1.Controls.Add(this.Tab7);
            this.tabControl1.Controls.Add(this.Tab8);
            this.tabControl1.Controls.Add(this.Tab9);
            this.tabControl1.Controls.Add(this.Tab10);
            this.tabControl1.Controls.Add(this.Tab11);
            this.tabControl1.Font = new System.Drawing.Font("Proxima Nova Rg", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 0);
            this.tabControl1.Location = new System.Drawing.Point(25, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 26);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Tab1
            // 
            this.Tab1.Location = new System.Drawing.Point(4, 25);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(855, 0);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "Сентябрь";
            this.Tab1.UseVisualStyleBackColor = true;
            // 
            // Tab2
            // 
            this.Tab2.Location = new System.Drawing.Point(4, 25);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(855, 0);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "Октябрь";
            this.Tab2.UseVisualStyleBackColor = true;
            // 
            // Tab3
            // 
            this.Tab3.Location = new System.Drawing.Point(4, 25);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(855, 0);
            this.Tab3.TabIndex = 2;
            this.Tab3.Text = "Ноябрь";
            this.Tab3.UseVisualStyleBackColor = true;
            // 
            // Tab4
            // 
            this.Tab4.Location = new System.Drawing.Point(4, 25);
            this.Tab4.Name = "Tab4";
            this.Tab4.Size = new System.Drawing.Size(855, 0);
            this.Tab4.TabIndex = 3;
            this.Tab4.Text = "Декабрь";
            this.Tab4.UseVisualStyleBackColor = true;
            // 
            // Tab5
            // 
            this.Tab5.Location = new System.Drawing.Point(4, 25);
            this.Tab5.Name = "Tab5";
            this.Tab5.Size = new System.Drawing.Size(855, 0);
            this.Tab5.TabIndex = 4;
            this.Tab5.Text = "Январь";
            this.Tab5.UseVisualStyleBackColor = true;
            // 
            // Tab6
            // 
            this.Tab6.Location = new System.Drawing.Point(4, 25);
            this.Tab6.Name = "Tab6";
            this.Tab6.Size = new System.Drawing.Size(855, 0);
            this.Tab6.TabIndex = 5;
            this.Tab6.Text = "Февраль";
            this.Tab6.UseVisualStyleBackColor = true;
            // 
            // Tab7
            // 
            this.Tab7.Location = new System.Drawing.Point(4, 25);
            this.Tab7.Name = "Tab7";
            this.Tab7.Size = new System.Drawing.Size(855, 0);
            this.Tab7.TabIndex = 6;
            this.Tab7.Text = "Март";
            this.Tab7.UseVisualStyleBackColor = true;
            // 
            // Tab8
            // 
            this.Tab8.Location = new System.Drawing.Point(4, 25);
            this.Tab8.Name = "Tab8";
            this.Tab8.Size = new System.Drawing.Size(855, 0);
            this.Tab8.TabIndex = 7;
            this.Tab8.Text = "Апрель";
            this.Tab8.UseVisualStyleBackColor = true;
            // 
            // Tab9
            // 
            this.Tab9.Location = new System.Drawing.Point(4, 25);
            this.Tab9.Name = "Tab9";
            this.Tab9.Size = new System.Drawing.Size(855, 0);
            this.Tab9.TabIndex = 8;
            this.Tab9.Text = "Май";
            this.Tab9.UseVisualStyleBackColor = true;
            // 
            // Tab10
            // 
            this.Tab10.Location = new System.Drawing.Point(4, 25);
            this.Tab10.Name = "Tab10";
            this.Tab10.Size = new System.Drawing.Size(855, 0);
            this.Tab10.TabIndex = 9;
            this.Tab10.Text = "Июнь";
            this.Tab10.UseVisualStyleBackColor = true;
            // 
            // Tab11
            // 
            this.Tab11.Location = new System.Drawing.Point(4, 25);
            this.Tab11.Name = "Tab11";
            this.Tab11.Size = new System.Drawing.Size(855, 0);
            this.Tab11.TabIndex = 10;
            this.Tab11.Text = "Июль";
            this.Tab11.UseVisualStyleBackColor = true;
            // 
            // LabelTitleLog
            // 
            this.LabelTitleLog.AutoSize = true;
            this.LabelTitleLog.Font = new System.Drawing.Font("Proxima Nova Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitleLog.Location = new System.Drawing.Point(19, 12);
            this.LabelTitleLog.Name = "LabelTitleLog";
            this.LabelTitleLog.Size = new System.Drawing.Size(207, 33);
            this.LabelTitleLog.TabIndex = 62;
            this.LabelTitleLog.Text = "Модуль журнал";
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(18, 500);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "«";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGroup.Location = new System.Drawing.Point(450, 3);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(443, 26);
            this.buttonGroup.TabIndex = 1;
            this.buttonGroup.Text = "Пм121-1";
            this.buttonGroup.UseVisualStyleBackColor = true;
            // 
            // buttonDisciplina
            // 
            this.buttonDisciplina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisciplina.Location = new System.Drawing.Point(450, 30);
            this.buttonDisciplina.Name = "buttonDisciplina";
            this.buttonDisciplina.Size = new System.Drawing.Size(443, 25);
            this.buttonDisciplina.TabIndex = 2;
            this.buttonDisciplina.Text = "Операционные системы";
            this.buttonDisciplina.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Font = new System.Drawing.Font("Proxima Nova Rg", 12F);
            this.Grid.LeftIndexDisableColumn = 1;
            this.Grid.Location = new System.Drawing.Point(25, 82);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RightIndexDisableColumn = 2;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowTemplate.Height = 30;
            this.Grid.RowTemplate.ReadOnly = true;
            this.Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.Size = new System.Drawing.Size(868, 382);
            this.Grid.TabIndex = 9;
            // 
            // CP_SelectedLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDisciplina);
            this.Controls.Add(this.comboBoxTypeValues);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.LabelTitleLog);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.easyEdit);
            this.Controls.Add(this.tabControl1);
            this.Name = "CP_SelectedLog";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.CP_SelectedLog_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AppLogMySQL.UC_Panels.UC_CustomDataGridView Grid;
        private System.Windows.Forms.ComboBox comboBoxTypeValues;
        private System.Windows.Forms.CheckBox easyEdit;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab2;
        private System.Windows.Forms.TabPage Tab3;
        private System.Windows.Forms.TabPage Tab4;
        private System.Windows.Forms.TabPage Tab5;
        private System.Windows.Forms.TabPage Tab6;
        private System.Windows.Forms.TabPage Tab7;
        private System.Windows.Forms.TabPage Tab8;
        private System.Windows.Forms.TabPage Tab9;
        private System.Windows.Forms.TabPage Tab10;
        private System.Windows.Forms.TabPage Tab11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label LabelTitleLog;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDisciplina;
    }
}

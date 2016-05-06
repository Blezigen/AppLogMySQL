namespace AppLogMySQL.Components.Graphics.Window
{
    partial class Window_Log
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.GeneralDataGrid = new System.Windows.Forms.DataGridView();
            this.logoPicture = new AppLogMySQL.UC_Panels.UC_TransparentControl();
            this.TabControll = new System.Windows.Forms.TabControl();
            this.SEP = new System.Windows.Forms.TabPage();
            this.OCT = new System.Windows.Forms.TabPage();
            this.NOV = new System.Windows.Forms.TabPage();
            this.DEC = new System.Windows.Forms.TabPage();
            this.JAN = new System.Windows.Forms.TabPage();
            this.FEB = new System.Windows.Forms.TabPage();
            this.MAR = new System.Windows.Forms.TabPage();
            this.APR = new System.Windows.Forms.TabPage();
            this.MAY = new System.Windows.Forms.TabPage();
            this.JUN = new System.Windows.Forms.TabPage();
            this.JUL = new System.Windows.Forms.TabPage();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDataGrid)).BeginInit();
            this.TabControll.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 22);
            this.label1.TabIndex = 114;
            this.label1.Text = "Журнал:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelTitle.Size = new System.Drawing.Size(904, 30);
            this.panelTitle.TabIndex = 113;
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
            this.labelTitle.Size = new System.Drawing.Size(824, 24);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Журнал успеваемости";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Image = global::AppLogMySQL.ResourceApplication.Close;
            this.CloseButton.Location = new System.Drawing.Point(877, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            // 
            // GeneralDataGrid
            // 
            this.GeneralDataGrid.AllowUserToAddRows = false;
            this.GeneralDataGrid.AllowUserToResizeColumns = false;
            this.GeneralDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GeneralDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GeneralDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Proxima Nova Rg", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GeneralDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GeneralDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Proxima Nova Rg", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GeneralDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.GeneralDataGrid.Location = new System.Drawing.Point(2, 75);
            this.GeneralDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.GeneralDataGrid.MultiSelect = false;
            this.GeneralDataGrid.Name = "GeneralDataGrid";
            this.GeneralDataGrid.RowHeadersVisible = false;
            this.GeneralDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GeneralDataGrid.RowTemplate.Height = 23;
            this.GeneralDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GeneralDataGrid.Size = new System.Drawing.Size(900, 444);
            this.GeneralDataGrid.TabIndex = 115;
            this.GeneralDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GeneralDataGrid_CellClick);
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
            this.logoPicture.TabIndex = 112;
            this.logoPicture.TranspKey = System.Drawing.Color.White;
            // 
            // TabControll
            // 
            this.TabControll.Controls.Add(this.SEP);
            this.TabControll.Controls.Add(this.OCT);
            this.TabControll.Controls.Add(this.NOV);
            this.TabControll.Controls.Add(this.DEC);
            this.TabControll.Controls.Add(this.JAN);
            this.TabControll.Controls.Add(this.FEB);
            this.TabControll.Controls.Add(this.MAR);
            this.TabControll.Controls.Add(this.APR);
            this.TabControll.Controls.Add(this.MAY);
            this.TabControll.Controls.Add(this.JUN);
            this.TabControll.Controls.Add(this.JUL);
            this.TabControll.Font = new System.Drawing.Font("Proxima Nova Rg", 9F);
            this.TabControll.ItemSize = new System.Drawing.Size(74, 20);
            this.TabControll.Location = new System.Drawing.Point(2, 53);
            this.TabControll.Name = "TabControll";
            this.TabControll.SelectedIndex = 0;
            this.TabControll.Size = new System.Drawing.Size(900, 22);
            this.TabControll.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControll.TabIndex = 116;
            this.TabControll.SelectedIndexChanged += new System.EventHandler(this.TabControll_SelectedIndexChanged);
            this.TabControll.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControll_Selected);
            // 
            // SEP
            // 
            this.SEP.Location = new System.Drawing.Point(4, 24);
            this.SEP.Name = "SEP";
            this.SEP.Padding = new System.Windows.Forms.Padding(3);
            this.SEP.Size = new System.Drawing.Size(892, 0);
            this.SEP.TabIndex = 0;
            this.SEP.Text = "Сентябрь";
            this.SEP.UseVisualStyleBackColor = true;
            // 
            // OCT
            // 
            this.OCT.Location = new System.Drawing.Point(4, 24);
            this.OCT.Name = "OCT";
            this.OCT.Padding = new System.Windows.Forms.Padding(3);
            this.OCT.Size = new System.Drawing.Size(892, 0);
            this.OCT.TabIndex = 1;
            this.OCT.Text = "Октябрь";
            this.OCT.UseVisualStyleBackColor = true;
            // 
            // NOV
            // 
            this.NOV.Location = new System.Drawing.Point(4, 24);
            this.NOV.Name = "NOV";
            this.NOV.Padding = new System.Windows.Forms.Padding(3);
            this.NOV.Size = new System.Drawing.Size(892, 0);
            this.NOV.TabIndex = 2;
            this.NOV.Text = "Ноябрь";
            this.NOV.UseVisualStyleBackColor = true;
            // 
            // DEC
            // 
            this.DEC.Location = new System.Drawing.Point(4, 24);
            this.DEC.Name = "DEC";
            this.DEC.Padding = new System.Windows.Forms.Padding(3);
            this.DEC.Size = new System.Drawing.Size(892, 0);
            this.DEC.TabIndex = 3;
            this.DEC.Text = "Декабрь";
            this.DEC.UseVisualStyleBackColor = true;
            // 
            // JAN
            // 
            this.JAN.Location = new System.Drawing.Point(4, 24);
            this.JAN.Name = "JAN";
            this.JAN.Padding = new System.Windows.Forms.Padding(3);
            this.JAN.Size = new System.Drawing.Size(892, 0);
            this.JAN.TabIndex = 4;
            this.JAN.Text = "Январь";
            this.JAN.UseVisualStyleBackColor = true;
            // 
            // FEB
            // 
            this.FEB.Location = new System.Drawing.Point(4, 24);
            this.FEB.Name = "FEB";
            this.FEB.Padding = new System.Windows.Forms.Padding(3);
            this.FEB.Size = new System.Drawing.Size(892, 0);
            this.FEB.TabIndex = 5;
            this.FEB.Text = "Февраль";
            this.FEB.UseVisualStyleBackColor = true;
            // 
            // MAR
            // 
            this.MAR.Location = new System.Drawing.Point(4, 24);
            this.MAR.Name = "MAR";
            this.MAR.Padding = new System.Windows.Forms.Padding(3);
            this.MAR.Size = new System.Drawing.Size(892, 0);
            this.MAR.TabIndex = 6;
            this.MAR.Text = "Март";
            this.MAR.UseVisualStyleBackColor = true;
            // 
            // APR
            // 
            this.APR.Location = new System.Drawing.Point(4, 24);
            this.APR.Name = "APR";
            this.APR.Padding = new System.Windows.Forms.Padding(3);
            this.APR.Size = new System.Drawing.Size(892, 0);
            this.APR.TabIndex = 7;
            this.APR.Text = "Апрель";
            this.APR.UseVisualStyleBackColor = true;
            // 
            // MAY
            // 
            this.MAY.Location = new System.Drawing.Point(4, 24);
            this.MAY.Name = "MAY";
            this.MAY.Padding = new System.Windows.Forms.Padding(3);
            this.MAY.Size = new System.Drawing.Size(892, 0);
            this.MAY.TabIndex = 8;
            this.MAY.Text = "Май";
            this.MAY.UseVisualStyleBackColor = true;
            // 
            // JUN
            // 
            this.JUN.Location = new System.Drawing.Point(4, 24);
            this.JUN.Name = "JUN";
            this.JUN.Padding = new System.Windows.Forms.Padding(3);
            this.JUN.Size = new System.Drawing.Size(892, 0);
            this.JUN.TabIndex = 9;
            this.JUN.Text = "Июнь";
            this.JUN.UseVisualStyleBackColor = true;
            // 
            // JUL
            // 
            this.JUL.Location = new System.Drawing.Point(4, 24);
            this.JUL.Name = "JUL";
            this.JUL.Padding = new System.Windows.Forms.Padding(3);
            this.JUL.Size = new System.Drawing.Size(892, 0);
            this.JUL.TabIndex = 10;
            this.JUL.Text = "Июль";
            this.JUL.UseVisualStyleBackColor = true;
            // 
            // Window_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.TabControll);
            this.Controls.Add(this.GeneralDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Proxima Nova Rg", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window_Log";
            this.Text = "Widow_Log";
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDataGrid)).EndInit();
            this.TabControll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UC_Panels.UC_TransparentControl logoPicture;
        private System.Windows.Forms.Panel panelTitle;
        public System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.DataGridView GeneralDataGrid;
        private System.Windows.Forms.TabControl TabControll;
        private System.Windows.Forms.TabPage SEP;
        private System.Windows.Forms.TabPage OCT;
        private System.Windows.Forms.TabPage NOV;
        private System.Windows.Forms.TabPage DEC;
        private System.Windows.Forms.TabPage JAN;
        private System.Windows.Forms.TabPage FEB;
        private System.Windows.Forms.TabPage MAR;
        private System.Windows.Forms.TabPage APR;
        private System.Windows.Forms.TabPage MAY;
        private System.Windows.Forms.TabPage JUN;
        private System.Windows.Forms.TabPage JUL;
    }
}
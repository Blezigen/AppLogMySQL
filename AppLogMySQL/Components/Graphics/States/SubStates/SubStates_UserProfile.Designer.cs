namespace AppLogMySQL.Components.Graphics.States.SubStates
{
    partial class SubStates_UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubStates_UserProfile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProfileImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GeneralDataGrid = new System.Windows.Forms.DataGridView();
            this.param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAVG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileImage
            // 
            this.ProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImage.Image")));
            this.ProfileImage.Location = new System.Drawing.Point(6, 20);
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.Size = new System.Drawing.Size(230, 230);
            this.ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileImage.TabIndex = 86;
            this.ProfileImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAVG);
            this.groupBox1.Controls.Add(this.GeneralDataGrid);
            this.groupBox1.Controls.Add(this.ProfileImage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 307);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональные данные";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GeneralDataGrid
            // 
            this.GeneralDataGrid.AllowUserToAddRows = false;
            this.GeneralDataGrid.AllowUserToDeleteRows = false;
            this.GeneralDataGrid.AllowUserToResizeColumns = false;
            this.GeneralDataGrid.AllowUserToResizeRows = false;
            this.GeneralDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneralDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GeneralDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.param,
            this.Value});
            this.GeneralDataGrid.Location = new System.Drawing.Point(241, 20);
            this.GeneralDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.GeneralDataGrid.MultiSelect = false;
            this.GeneralDataGrid.Name = "GeneralDataGrid";
            this.GeneralDataGrid.ReadOnly = true;
            this.GeneralDataGrid.RowHeadersVisible = false;
            this.GeneralDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GeneralDataGrid.RowTemplate.Height = 23;
            this.GeneralDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GeneralDataGrid.Size = new System.Drawing.Size(351, 282);
            this.GeneralDataGrid.TabIndex = 113;
            // 
            // param
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.param.DefaultCellStyle = dataGridViewCellStyle1;
            this.param.HeaderText = "Param";
            this.param.MinimumWidth = 150;
            this.param.Name = "param";
            this.param.ReadOnly = true;
            this.param.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.param.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.param.Width = 150;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Value.DefaultCellStyle = dataGridViewCellStyle2;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonAVG
            // 
            this.buttonAVG.Location = new System.Drawing.Point(6, 256);
            this.buttonAVG.Name = "buttonAVG";
            this.buttonAVG.Size = new System.Drawing.Size(230, 23);
            this.buttonAVG.TabIndex = 114;
            this.buttonAVG.Text = "Оценки";
            this.buttonAVG.UseVisualStyleBackColor = true;
            this.buttonAVG.Click += new System.EventHandler(this.buttonAVG_Click);
            // 
            // SubStates_UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(597, 307);
            this.Name = "SubStates_UserProfile";
            this.Size = new System.Drawing.Size(597, 307);
            this.Load += new System.EventHandler(this.SubStates_UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfileImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GeneralDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn param;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button buttonAVG;

    }
}

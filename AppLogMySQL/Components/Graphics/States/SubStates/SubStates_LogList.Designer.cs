namespace AppLogMySQL.Components.Graphics.States.SubStates
{
    partial class SubStates_LogList
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
            this.LogDock = new SubStates_SelectedLog();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLog = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // LogDock
            // 
            this.LogDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogDock.Location = new System.Drawing.Point(0, 0);
            this.LogDock.Name = "LogDock";
            this.LogDock.Size = new System.Drawing.Size(670, 440);
            this.LogDock.TabIndex = 0;
            this.LogDock.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 64;
            this.label1.Text = "Журналы";
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnGroup,
            this.ColumnDiscipline});
            this.dataGridViewLogs.Location = new System.Drawing.Point(4, 52);
            this.dataGridViewLogs.MultiSelect = false;
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.RowHeadersVisible = false;
            this.dataGridViewLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLogs.Size = new System.Drawing.Size(662, 381);
            this.dataGridViewLogs.TabIndex = 63;
            this.dataGridViewLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLogs_CellContentClick);
            this.dataGridViewLogs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewLogs_MouseDoubleClick);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.Frozen = true;
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.MinimumWidth = 30;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 30;
            // 
            // ColumnGroup
            // 
            this.ColumnGroup.Frozen = true;
            this.ColumnGroup.HeaderText = "Группа";
            this.ColumnGroup.Name = "ColumnGroup";
            this.ColumnGroup.ReadOnly = true;
            // 
            // ColumnDiscipline
            // 
            this.ColumnDiscipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDiscipline.HeaderText = "Дисциплина";
            this.ColumnDiscipline.Name = "ColumnDiscipline";
            this.ColumnDiscipline.ReadOnly = true;
            // 
            // panelLog
            // 
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(0, 0);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(670, 440);
            this.panelLog.TabIndex = 65;
            this.panelLog.Visible = false;
            // 
            // CP_LogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogDock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLogs);
            this.Name = "CP_LogList";
            this.Size = new System.Drawing.Size(670, 440);
            this.Load += new System.EventHandler(this.CP_LogList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SubStates_SelectedLog LogDock;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscipline;
        private System.Windows.Forms.Panel panelLog;
    }
}

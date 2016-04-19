namespace AppLogMySQL.Components.Graphics.States
{
    partial class State_ControllPanel
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
            this.buttonExitSystem = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelControlls = new AppLogMySQL.Components.Graphics.States.StateManager();
            this.panel1 = new AppLogMySQL.Components.Graphics.Controls.CustomPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonShowAdministrator = new System.Windows.Forms.Button();
            this.buttonShowModerator = new System.Windows.Forms.Button();
            this.buttonShowTeachMaterials = new System.Windows.Forms.Button();
            this.buttonShowStudentControll = new System.Windows.Forms.Button();
            this.buttonShowCuriculumb = new System.Windows.Forms.Button();
            this.buttonShowLogs = new System.Windows.Forms.Button();
            this.buttonShowWeekLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExitSystem
            // 
            this.buttonExitSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExitSystem.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitSystem.Location = new System.Drawing.Point(989, 11);
            this.buttonExitSystem.Name = "buttonExitSystem";
            this.buttonExitSystem.Size = new System.Drawing.Size(99, 29);
            this.buttonExitSystem.TabIndex = 33;
            this.buttonExitSystem.Text = "Выход";
            this.buttonExitSystem.UseVisualStyleBackColor = true;
            this.buttonExitSystem.Click += new System.EventHandler(this.buttonExitSystem_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Font = new System.Drawing.Font("Proxima Nova Rg", 12F);
            this.buttonHelp.Location = new System.Drawing.Point(881, 11);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(99, 29);
            this.buttonHelp.TabIndex = 32;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Proxima Nova Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(220, 33);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "Личный кабинет";
            // 
            // panelControlls
            // 
            this.panelControlls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlls.ForeColor = System.Drawing.Color.Black;
            this.panelControlls.Location = new System.Drawing.Point(219, 46);
            this.panelControlls.Name = "panelControlls";
            this.panelControlls.Size = new System.Drawing.Size(871, 613);
            this.panelControlls.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(159)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.buttonShowAdministrator);
            this.panel1.Controls.Add(this.buttonShowModerator);
            this.panel1.Controls.Add(this.buttonShowTeachMaterials);
            this.panel1.Controls.Add(this.buttonShowStudentControll);
            this.panel1.Controls.Add(this.buttonShowCuriculumb);
            this.panel1.Controls.Add(this.buttonShowLogs);
            this.panel1.Controls.Add(this.buttonShowWeekLog);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 613);
            this.panel1.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.button4.Location = new System.Drawing.Point(0, 583);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Настройки";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonShowAdministrator
            // 
            this.buttonShowAdministrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowAdministrator.Enabled = false;
            this.buttonShowAdministrator.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.buttonShowAdministrator.Location = new System.Drawing.Point(0, 180);
            this.buttonShowAdministrator.Name = "buttonShowAdministrator";
            this.buttonShowAdministrator.Size = new System.Drawing.Size(200, 30);
            this.buttonShowAdministrator.TabIndex = 6;
            this.buttonShowAdministrator.Text = "Администрирование";
            this.buttonShowAdministrator.UseVisualStyleBackColor = true;
            this.buttonShowAdministrator.Visible = false;
            // 
            // buttonShowModerator
            // 
            this.buttonShowModerator.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowModerator.Enabled = false;
            this.buttonShowModerator.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.buttonShowModerator.Location = new System.Drawing.Point(0, 150);
            this.buttonShowModerator.Name = "buttonShowModerator";
            this.buttonShowModerator.Size = new System.Drawing.Size(200, 30);
            this.buttonShowModerator.TabIndex = 7;
            this.buttonShowModerator.Text = "Модерирование";
            this.buttonShowModerator.UseVisualStyleBackColor = true;
            this.buttonShowModerator.Visible = false;
            // 
            // buttonShowTeachMaterials
            // 
            this.buttonShowTeachMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowTeachMaterials.Enabled = false;
            this.buttonShowTeachMaterials.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.buttonShowTeachMaterials.Location = new System.Drawing.Point(0, 120);
            this.buttonShowTeachMaterials.Name = "buttonShowTeachMaterials";
            this.buttonShowTeachMaterials.Size = new System.Drawing.Size(200, 30);
            this.buttonShowTeachMaterials.TabIndex = 5;
            this.buttonShowTeachMaterials.Text = "Методические материалы";
            this.buttonShowTeachMaterials.UseVisualStyleBackColor = true;
            // 
            // buttonShowStudentControll
            // 
            this.buttonShowStudentControll.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowStudentControll.Enabled = false;
            this.buttonShowStudentControll.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.buttonShowStudentControll.Location = new System.Drawing.Point(0, 90);
            this.buttonShowStudentControll.Name = "buttonShowStudentControll";
            this.buttonShowStudentControll.Size = new System.Drawing.Size(200, 30);
            this.buttonShowStudentControll.TabIndex = 8;
            this.buttonShowStudentControll.Text = "Контроль успеваемости";
            this.buttonShowStudentControll.UseVisualStyleBackColor = true;
            // 
            // buttonShowCuriculumb
            // 
            this.buttonShowCuriculumb.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowCuriculumb.Enabled = false;
            this.buttonShowCuriculumb.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.buttonShowCuriculumb.Location = new System.Drawing.Point(0, 60);
            this.buttonShowCuriculumb.Name = "buttonShowCuriculumb";
            this.buttonShowCuriculumb.Size = new System.Drawing.Size(200, 30);
            this.buttonShowCuriculumb.TabIndex = 3;
            this.buttonShowCuriculumb.Text = "Учебные планы";
            this.buttonShowCuriculumb.UseVisualStyleBackColor = true;
            // 
            // buttonShowLogs
            // 
            this.buttonShowLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowLogs.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.buttonShowLogs.Location = new System.Drawing.Point(0, 30);
            this.buttonShowLogs.Name = "buttonShowLogs";
            this.buttonShowLogs.Size = new System.Drawing.Size(200, 30);
            this.buttonShowLogs.TabIndex = 2;
            this.buttonShowLogs.Text = "Журналы";
            this.buttonShowLogs.UseVisualStyleBackColor = true;
            this.buttonShowLogs.Click += new System.EventHandler(this.buttonShowLogs_Click);
            // 
            // buttonShowWeekLog
            // 
            this.buttonShowWeekLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowWeekLog.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.buttonShowWeekLog.Location = new System.Drawing.Point(0, 0);
            this.buttonShowWeekLog.Name = "buttonShowWeekLog";
            this.buttonShowWeekLog.Size = new System.Drawing.Size(200, 30);
            this.buttonShowWeekLog.TabIndex = 1;
            this.buttonShowWeekLog.Text = "Расписание";
            this.buttonShowWeekLog.UseVisualStyleBackColor = true;
            this.buttonShowWeekLog.Click += new System.EventHandler(this.buttonShowWeekLog_Click);
            // 
            // State_ControllPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.panelControlls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExitSystem);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("HelveticaNeueCyr", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "State_ControllPanel";
            this.Size = new System.Drawing.Size(1100, 670);
            this.Load += new System.EventHandler(this.UC_ControllPanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Graphics.Controls.CustomPanel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonShowAdministrator;
        private System.Windows.Forms.Button buttonShowModerator;
        private System.Windows.Forms.Button buttonShowTeachMaterials;
        private System.Windows.Forms.Button buttonShowStudentControll;
        private System.Windows.Forms.Button buttonShowCuriculumb;
        private System.Windows.Forms.Button buttonShowLogs;
        private System.Windows.Forms.Button buttonShowWeekLog;
        private System.Windows.Forms.Button buttonExitSystem;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelTitle;
        private StateManager panelControlls;
    }
}

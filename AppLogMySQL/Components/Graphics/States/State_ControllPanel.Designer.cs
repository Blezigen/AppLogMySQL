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
            this.buttonSpecialization = new System.Windows.Forms.Button();
            this.buttonDiscipline = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.panelControlls = new AppLogMySQL.Components.Graphics.States.StateManager();
            this.SuspendLayout();
            // 
            // buttonExitSystem
            // 
            this.buttonExitSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExitSystem.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitSystem.Location = new System.Drawing.Point(496, 29);
            this.buttonExitSystem.Name = "buttonExitSystem";
            this.buttonExitSystem.Size = new System.Drawing.Size(100, 23);
            this.buttonExitSystem.TabIndex = 33;
            this.buttonExitSystem.Text = "Выход";
            this.buttonExitSystem.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(397, 29);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 23);
            this.buttonHelp.TabIndex = 32;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(5, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(559, 21);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "Личный кабинет";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSpecialization
            // 
            this.buttonSpecialization.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpecialization.Location = new System.Drawing.Point(199, 29);
            this.buttonSpecialization.Name = "buttonSpecialization";
            this.buttonSpecialization.Size = new System.Drawing.Size(100, 23);
            this.buttonSpecialization.TabIndex = 42;
            this.buttonSpecialization.Text = "Специальности";
            this.buttonSpecialization.UseVisualStyleBackColor = true;
            // 
            // buttonDiscipline
            // 
            this.buttonDiscipline.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscipline.Location = new System.Drawing.Point(100, 29);
            this.buttonDiscipline.Name = "buttonDiscipline";
            this.buttonDiscipline.Size = new System.Drawing.Size(100, 23);
            this.buttonDiscipline.TabIndex = 37;
            this.buttonDiscipline.Text = "Дисциплины";
            this.buttonDiscipline.UseVisualStyleBackColor = true;
            // 
            // buttonGroups
            // 
            this.buttonGroups.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGroups.Location = new System.Drawing.Point(1, 29);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(100, 23);
            this.buttonGroups.TabIndex = 36;
            this.buttonGroups.Text = "Группы";
            this.buttonGroups.UseVisualStyleBackColor = true;
            // 
            // panelControlls
            // 
            this.panelControlls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlls.ForeColor = System.Drawing.Color.Black;
            this.panelControlls.Location = new System.Drawing.Point(2, 55);
            this.panelControlls.Name = "panelControlls";
            this.panelControlls.Size = new System.Drawing.Size(593, 250);
            this.panelControlls.TabIndex = 35;
            // 
            // State_ControllPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.buttonSpecialization);
            this.Controls.Add(this.buttonDiscipline);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.panelControlls);
            this.Controls.Add(this.buttonExitSystem);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("HelveticaNeueCyr", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(597, 307);
            this.Name = "State_ControllPanel";
            this.Size = new System.Drawing.Size(597, 307);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitSystem;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelTitle;
        private StateManager panelControlls;
        private System.Windows.Forms.Button buttonSpecialization;
        private System.Windows.Forms.Button buttonDiscipline;
        private System.Windows.Forms.Button buttonGroups;
    }
}

namespace AppLogMySQL.Components.Graphics.States
{
    partial class State_UserAuthorization
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
            this.PatrtnerLogoPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new AppLogMySQL.Components.Graphics.Controls.CustomPanel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginEdit = new System.Windows.Forms.TextBox();
            this.passwordEdit = new System.Windows.Forms.TextBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatrtnerLogoPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PatrtnerLogoPicture
            // 
            this.PatrtnerLogoPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PatrtnerLogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.PatrtnerLogoPicture.Image = global::AppLogMySQL.ResourceApplication.Logo_Partner;
            this.PatrtnerLogoPicture.InitialImage = null;
            this.PatrtnerLogoPicture.Location = new System.Drawing.Point(3, 414);
            this.PatrtnerLogoPicture.MaximumSize = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.MinimumSize = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.Name = "PatrtnerLogoPicture";
            this.PatrtnerLogoPicture.Size = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatrtnerLogoPicture.TabIndex = 5;
            this.PatrtnerLogoPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.loginEdit);
            this.panel1.Controls.Add(this.passwordEdit);
            this.panel1.Controls.Add(this.logoPicture);
            this.panel1.Location = new System.Drawing.Point(200, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(200, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 365);
            this.panel1.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(74, 232);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(180, 28);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginEdit
            // 
            this.loginEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginEdit.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginEdit.Location = new System.Drawing.Point(74, 170);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Size = new System.Drawing.Size(180, 25);
            this.loginEdit.TabIndex = 0;
            // 
            // passwordEdit
            // 
            this.passwordEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordEdit.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordEdit.Location = new System.Drawing.Point(74, 202);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.PasswordChar = '*';
            this.passwordEdit.Size = new System.Drawing.Size(180, 25);
            this.passwordEdit.TabIndex = 1;
            // 
            // logoPicture
            // 
            this.logoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.Image = global::AppLogMySQL.ResourceApplication.logo;
            this.logoPicture.InitialImage = null;
            this.logoPicture.Location = new System.Drawing.Point(100, 32);
            this.logoPicture.MaximumSize = new System.Drawing.Size(128, 128);
            this.logoPicture.MinimumSize = new System.Drawing.Size(128, 128);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(128, 128);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 3;
            this.logoPicture.TabStop = false;
            // 
            // State_UserAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatrtnerLogoPicture);
            this.Name = "State_UserAuthorization";
            this.Size = new System.Drawing.Size(729, 465);
            ((System.ComponentModel.ISupportInitialize)(this.PatrtnerLogoPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomPanel panel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginEdit;
        private System.Windows.Forms.TextBox passwordEdit;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.PictureBox PatrtnerLogoPicture;
    }
}

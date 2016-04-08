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
            this.labelTitle = new System.Windows.Forms.Label();
            this.ProfileImage = new System.Windows.Forms.PictureBox();
            this.ListDataProfile = new AppLogMySQL.Components.Graphics.Controls.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Proxima Nova Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(299, 33);
            this.labelTitle.TabIndex = 61;
            this.labelTitle.Text = "Персональные данные";
            // 
            // ProfileImage
            // 
            this.ProfileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImage.Image")));
            this.ProfileImage.Location = new System.Drawing.Point(627, 62);
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.Size = new System.Drawing.Size(230, 230);
            this.ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileImage.TabIndex = 86;
            this.ProfileImage.TabStop = false;
            // 
            // ListDataProfile
            // 
            this.ListDataProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListDataProfile.BorderColor = System.Drawing.Color.Transparent;
            this.ListDataProfile.Location = new System.Drawing.Point(18, 62);
            this.ListDataProfile.Name = "ListDataProfile";
            this.ListDataProfile.Size = new System.Drawing.Size(594, 531);
            this.ListDataProfile.TabIndex = 0;
            // 
            // SubStates_UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListDataProfile);
            this.Controls.Add(this.ProfileImage);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("HelveticaNeueCyr", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SubStates_UserProfile";
            this.Size = new System.Drawing.Size(869, 611);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppLogMySQL.Components.Graphics.Controls.CustomPanel ListDataProfile;
        private System.Windows.Forms.PictureBox ProfileImage;
        private System.Windows.Forms.Label labelTitle;

    }
}

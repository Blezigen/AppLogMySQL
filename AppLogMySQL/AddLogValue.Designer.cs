namespace AppLogMySQL
{
    partial class AddLogValue
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
            this.panel = new AppLogMySQL.Gui.Components.CustomPanel();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.Location = new System.Drawing.Point(38, 26);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(174, 172);
            this.panel.TabIndex = 0;
            // 
            // AddLogValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 249);
            this.Controls.Add(this.panel);
            this.Name = "AddLogValue";
            this.Text = "AddLogValue";
            this.Load += new System.EventHandler(this.AddLogValue_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddLogValue_KeyDown);
            this.ResumeLayout(false);

        }

        private Gui.Components.CustomPanel panel;
        #endregion

    }
}
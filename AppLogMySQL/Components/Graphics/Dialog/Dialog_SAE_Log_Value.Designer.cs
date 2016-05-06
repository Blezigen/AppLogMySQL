namespace AppLogMySQL.Components.Graphics.Dialog
{
    partial class Dialog_SAE_Log_Value
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.buttonN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonValue5 = new System.Windows.Forms.Button();
            this.buttonValue4 = new System.Windows.Forms.Button();
            this.buttonValue3 = new System.Windows.Forms.Button();
            this.buttonValue2 = new System.Windows.Forms.Button();
            this.buttonValue1 = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.logoPicture = new AppLogMySQL.UC_Panels.UC_TransparentControl();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTitle.Size = new System.Drawing.Size(280, 30);
            this.panelTitle.TabIndex = 93;
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
            this.labelTitle.Size = new System.Drawing.Size(200, 24);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Редактор";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Image = global::AppLogMySQL.ResourceApplication.Close;
            this.CloseButton.Location = new System.Drawing.Point(253, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            // 
            // buttonN
            // 
            this.buttonN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonN.BackColor = System.Drawing.SystemColors.Control;
            this.buttonN.Location = new System.Drawing.Point(187, 48);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(88, 23);
            this.buttonN.TabIndex = 94;
            this.buttonN.Text = "Небыл";
            this.buttonN.UseVisualStyleBackColor = false;
            this.buttonN.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonValue5);
            this.groupBox1.Controls.Add(this.buttonValue4);
            this.groupBox1.Controls.Add(this.buttonValue3);
            this.groupBox1.Controls.Add(this.buttonValue2);
            this.groupBox1.Controls.Add(this.buttonValue1);
            this.groupBox1.Location = new System.Drawing.Point(1, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 82);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите оценку";
            // 
            // buttonValue5
            // 
            this.buttonValue5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValue5.Location = new System.Drawing.Point(218, 25);
            this.buttonValue5.Name = "buttonValue5";
            this.buttonValue5.Size = new System.Drawing.Size(45, 45);
            this.buttonValue5.TabIndex = 4;
            this.buttonValue5.Text = "5";
            this.buttonValue5.UseVisualStyleBackColor = false;
            this.buttonValue5.Click += new System.EventHandler(this.buttonValue5_Click);
            // 
            // buttonValue4
            // 
            this.buttonValue4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValue4.Location = new System.Drawing.Point(167, 25);
            this.buttonValue4.Name = "buttonValue4";
            this.buttonValue4.Size = new System.Drawing.Size(45, 45);
            this.buttonValue4.TabIndex = 3;
            this.buttonValue4.Text = "4";
            this.buttonValue4.UseVisualStyleBackColor = false;
            this.buttonValue4.Click += new System.EventHandler(this.buttonValue4_Click);
            // 
            // buttonValue3
            // 
            this.buttonValue3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValue3.BackColor = System.Drawing.SystemColors.Control;
            this.buttonValue3.Location = new System.Drawing.Point(116, 25);
            this.buttonValue3.Name = "buttonValue3";
            this.buttonValue3.Size = new System.Drawing.Size(45, 45);
            this.buttonValue3.TabIndex = 2;
            this.buttonValue3.Text = "3";
            this.buttonValue3.UseVisualStyleBackColor = false;
            this.buttonValue3.Click += new System.EventHandler(this.buttonValue3_Click);
            // 
            // buttonValue2
            // 
            this.buttonValue2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValue2.Location = new System.Drawing.Point(66, 25);
            this.buttonValue2.Name = "buttonValue2";
            this.buttonValue2.Size = new System.Drawing.Size(45, 45);
            this.buttonValue2.TabIndex = 1;
            this.buttonValue2.Text = "2";
            this.buttonValue2.UseVisualStyleBackColor = false;
            this.buttonValue2.Click += new System.EventHandler(this.buttonValue2_Click);
            // 
            // buttonValue1
            // 
            this.buttonValue1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValue1.Location = new System.Drawing.Point(15, 25);
            this.buttonValue1.Name = "buttonValue1";
            this.buttonValue1.Size = new System.Drawing.Size(45, 45);
            this.buttonValue1.TabIndex = 0;
            this.buttonValue1.Text = "1";
            this.buttonValue1.UseVisualStyleBackColor = false;
            this.buttonValue1.Click += new System.EventHandler(this.buttonValue1_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAccept.Location = new System.Drawing.Point(1, 136);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 26);
            this.buttonAccept.TabIndex = 26;
            this.buttonAccept.Text = "Ок";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(204, 136);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 26);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonB);
            this.groupBox2.Controls.Add(this.buttonY);
            this.groupBox2.Location = new System.Drawing.Point(1, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 82);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите причину";
            this.groupBox2.Visible = false;
            // 
            // buttonB
            // 
            this.buttonB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonB.Location = new System.Drawing.Point(5, 51);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(268, 27);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "Болел";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonY
            // 
            this.buttonY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonY.Location = new System.Drawing.Point(5, 22);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(268, 27);
            this.buttonY.TabIndex = 1;
            this.buttonY.Text = "Уважительная";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
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
            this.logoPicture.TabIndex = 92;
            this.logoPicture.TranspKey = System.Drawing.Color.White;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(104, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 97;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dialog_SAE_Log_Value
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(280, 163);
            this.Name = "Dialog_SAE_Log_Value";
            this.Text = "Form1";
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Panels.UC_TransparentControl logoPicture;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonValue5;
        private System.Windows.Forms.Button buttonValue4;
        private System.Windows.Forms.Button buttonValue3;
        private System.Windows.Forms.Button buttonValue2;
        private System.Windows.Forms.Button buttonValue1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button button1;
    }
}
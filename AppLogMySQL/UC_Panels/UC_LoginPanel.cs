using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppLogMySQL.UC_Panels
{
    public partial class UC_LoginPanel : UserControl
    {
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.TextBox passwordEdit;
        private System.Windows.Forms.TextBox loginEdit;
        private Gui.Components.CustomPanel panel1;
        private PictureBox PatrtnerLogoPicture;

        private void positionChanged()
        {

        }

        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordEdit = new System.Windows.Forms.TextBox();
            this.loginEdit = new System.Windows.Forms.TextBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.PatrtnerLogoPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new AppLogMySQL.Gui.Components.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrtnerLogoPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(60, 200);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(180, 28);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordEdit
            // 
            this.passwordEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordEdit.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordEdit.Location = new System.Drawing.Point(60, 170);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.PasswordChar = '*';
            this.passwordEdit.Size = new System.Drawing.Size(180, 25);
            this.passwordEdit.TabIndex = 1;
            this.passwordEdit.Text = "dasdasd";
            // 
            // loginEdit
            // 
            this.loginEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginEdit.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginEdit.Location = new System.Drawing.Point(60, 138);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Size = new System.Drawing.Size(180, 25);
            this.loginEdit.TabIndex = 0;
            this.loginEdit.Text = "dasdasd";
            // 
            // logoPicture
            // 
            this.logoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.Image = global::AppLogMySQL.ResourceApplication.logo;
            this.logoPicture.InitialImage = null;
            this.logoPicture.Location = new System.Drawing.Point(86, 0);
            this.logoPicture.MaximumSize = new System.Drawing.Size(128, 128);
            this.logoPicture.MinimumSize = new System.Drawing.Size(128, 128);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(128, 128);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 3;
            this.logoPicture.TabStop = false;
            // 
            // PatrtnerLogoPicture
            // 
            this.PatrtnerLogoPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PatrtnerLogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.PatrtnerLogoPicture.Image = global::AppLogMySQL.ResourceApplication.Logo_Partner;
            this.PatrtnerLogoPicture.InitialImage = null;
            this.PatrtnerLogoPicture.Location = new System.Drawing.Point(6, 346);
            this.PatrtnerLogoPicture.MaximumSize = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.MinimumSize = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.Name = "PatrtnerLogoPicture";
            this.PatrtnerLogoPicture.Size = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatrtnerLogoPicture.TabIndex = 3;
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
            this.panel1.Location = new System.Drawing.Point(150, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 4;
            // 
            // UC_LoginPanel
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatrtnerLogoPicture);
            this.Name = "UC_LoginPanel";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.UC_LoginPanel_Load);
            this.SizeChanged += new System.EventHandler(this.PanelLogin_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrtnerLogoPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public UC_LoginPanel()
        {
            InitializeComponent();
        }

        private void PanelLogin_SizeChanged(object sender, EventArgs e)
        {

           // this.groupBox.Location = new Point(Width / 2 - 100, Height / 2 - 40);
           // this.loginButton.Location = new Point(Width / 2 - 64, groupBox.Top + groupBox.Height + 5);
           // this.logoPicture.Location = new Point(Width / 2 - 64, groupBox.Top - 128 - 5);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var resultLogin = DataCollection.AccountData.loginAccount(loginEdit.Text, passwordEdit.Text);
            if ((bool)resultLogin["is_valid"])
            {
                //AddLogValue J = new AddLogValue();
                //J.Show();
                UC_Panels.UC_ControllPanel p = new UC_Panels.UC_ControllPanel();
                p.OnLoad();
                DataCollection._NextForm(p);
            }
            else
                MessageBox.Show((string)resultLogin["message"]);
        }

        private void UC_LoginPanel_Load(object sender, EventArgs e)
        {
            //207; 105; 67
            //233; 168;68
        }
    }
}

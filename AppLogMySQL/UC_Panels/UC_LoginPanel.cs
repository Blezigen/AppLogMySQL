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
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private PictureBox PatrtnerLogoPicture;
        private System.Windows.Forms.GroupBox groupBox;

        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordEdit = new System.Windows.Forms.TextBox();
            this.loginEdit = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.PatrtnerLogoPicture = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrtnerLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(400, 330);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(128, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordEdit
            // 
            this.passwordEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordEdit.Location = new System.Drawing.Point(58, 47);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.PasswordChar = '*';
            this.passwordEdit.Size = new System.Drawing.Size(128, 22);
            this.passwordEdit.TabIndex = 1;
            // 
            // loginEdit
            // 
            this.loginEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginEdit.Location = new System.Drawing.Point(58, 21);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Size = new System.Drawing.Size(128, 22);
            this.loginEdit.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(17, 26);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(10, 52);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox.Controls.Add(this.labelLogin);
            this.groupBox.Controls.Add(this.labelPassword);
            this.groupBox.Controls.Add(this.passwordEdit);
            this.groupBox.Controls.Add(this.loginEdit);
            this.groupBox.Location = new System.Drawing.Point(362, 248);
            this.groupBox.MaximumSize = new System.Drawing.Size(200, 80);
            this.groupBox.MinimumSize = new System.Drawing.Size(200, 80);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 80);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ввод";
            // 
            // logoPicture
            // 
            this.logoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.Image = global::AppLogMySQL.ResourceApplication.logo;
            this.logoPicture.InitialImage = null;
            this.logoPicture.Location = new System.Drawing.Point(400, 114);
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
            this.PatrtnerLogoPicture.Location = new System.Drawing.Point(6, 485);
            this.PatrtnerLogoPicture.MaximumSize = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.MinimumSize = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.Name = "PatrtnerLogoPicture";
            this.PatrtnerLogoPicture.Size = new System.Drawing.Size(48, 48);
            this.PatrtnerLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatrtnerLogoPicture.TabIndex = 3;
            this.PatrtnerLogoPicture.TabStop = false;
            // 
            // UC_LoginPanel
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.PatrtnerLogoPicture);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.groupBox);
            this.Name = "UC_LoginPanel";
            this.Size = new System.Drawing.Size(936, 539);
            this.Load += new System.EventHandler(this.UC_LoginPanel_Load);
            this.SizeChanged += new System.EventHandler(this.PanelLogin_SizeChanged);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrtnerLogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        public UC_LoginPanel()
        {
            InitializeComponent();
        }

        private void PanelLogin_SizeChanged(object sender, EventArgs e)
        {

            this.groupBox.Location = new Point(Width / 2 - 100, Height / 2 - 40);
            this.loginButton.Location = new Point(Width / 2 - 64, groupBox.Top + groupBox.Height + 5);
            this.logoPicture.Location = new Point(Width / 2 - 64, groupBox.Top - 128 - 5);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (DataCollection.AccountData.FillData(loginEdit.Text, passwordEdit.Text))
            {
                AddLogValue J = new AddLogValue();
                J.Show();
                //UC_Panels.UC_ControllPanel p = new UC_Panels.UC_ControllPanel();
                //p.OnLoad();
               // DataCollection._NextForm(p);
            }
        }

        private void UC_LoginPanel_Load(object sender, EventArgs e)
        {
            loginButton.Font = new Font("Proxima Nova", 10f, FontStyle.Regular);
            passwordEdit.Font = new Font("Proxima Nova", 8f, FontStyle.Regular);
            loginEdit.Font = new Font("Proxima Nova", 8f, FontStyle.Regular);
            labelLogin.Font = new Font("Proxima Nova", 8f, FontStyle.Regular);
            labelPassword.Font = new Font("Proxima Nova", 8f, FontStyle.Regular);
            groupBox.Font = new Font("Proxima Nova", 8f, FontStyle.Regular);
        }
    }
}

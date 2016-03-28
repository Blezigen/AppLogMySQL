using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppLogMySQL.ControllPanel.UserControls
{
    public partial class CP_UserProfile : UserControl
    {
        public CP_UserProfile()
        {
            InitializeComponent();
            
        }

        private void CP_UserProfile_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            labelFullName.Text =  DataCollection.AccountData._full_name;
            labelEnail.Text = DataCollection.AccountData._legal_adress;
            labelAdress.Text = "[Адрес скрыт]";//DataCollection.account._legal_adress;
            labelPhoneNumber.Text = "+7(000)000-00-00";//DataCollection.account._telphone;
            labelGender.Text = DataCollection.AccountData._gender;
            labelBithdate.Text = "[не заполнено]";//DataCollection.account.;
            labelSystemStatus.Text = DataCollection.AccountData._type;
            labelLogin.Text = "[логин скрыт]";//DataCollection.account._login;
            DataCollection.mainFormer.labelTitle.Text = string.Format("{0} - Электронный журнал успеваемости", DataCollection.AccountData._full_name);
        }
    }
}

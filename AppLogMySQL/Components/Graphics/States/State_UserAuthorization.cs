using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLogMySQL.Components.Data;
namespace AppLogMySQL.Components.Graphics.States
{
    public partial class State_UserAuthorization : UserControl
    {
        public State_UserAuthorization()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            var resultLogin = DataManager._account.login(loginEdit.Text, passwordEdit.Text);
            if (resultLogin.ContainsKey("Error"))
            {
                MessageBox.Show((string)resultLogin["Error"]);
            }
            else if (resultLogin["validator"].ToString() == "1")
            {
                DataManager.global_states.state_Change("ControllPanel");
            }
            else
                MessageBox.Show((string)resultLogin["message"]);
        }
    }
}

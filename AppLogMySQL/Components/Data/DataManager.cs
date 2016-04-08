using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AppLogMySQL.Components.MySql;
using AppLogMySQL.Components.Graphics.States;
namespace AppLogMySQL.Components.Data
{
    static class DataManager
    {
        public static MainForm generalForm;
        public static Font PROXIMA_NOVA_9R;
        public static MySQLManager _connection;
        public static AccountManager _account;
        public static AppLogMySQL.Components.Graphics.States.StateManager global_states;

        public static void initialisation()
        {
            _connection = new MySQLManager();
            _account = new AccountManager();
            PROXIMA_NOVA_9R = new Font("Proxima Nova", 9, FontStyle.Regular);
            global_states.add_State("Authorization", new State_UserAuthorization());
            global_states.add_State("ControllPanel", new State_ControllPanel());

            _connection.Open();
        }
    }
}

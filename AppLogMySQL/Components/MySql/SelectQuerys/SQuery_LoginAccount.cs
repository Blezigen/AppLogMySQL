using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_LoginAccount : BasicSelectQuery
    {
        string _login;
        string _password;
        
        public string login{
            set {
                _login = value;
            }
        }

        public string password
        {
            set
            {
                _password = value;
            }
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = String.Format("call loginAccount('{0}','{1}')", _login, _password);
            return base.run(_connection);
        }
    }
}

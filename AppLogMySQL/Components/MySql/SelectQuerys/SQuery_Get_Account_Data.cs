using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_Get_Account_Data : BasicSelectQuery
    {
        public override bool run(MySQLManager _connection)
        {
            query_str = "get_account_data()";
            return base.run(_connection);
        }
    }
}

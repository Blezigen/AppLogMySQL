using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_Get_Logs_AVG : BasicSelectQuery
    {

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("get_logs_avg()");
            return base.run(_connection);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    class IQuery_Insert_Schedule : BasicInsertQuery
    {
        public override bool run(MySQLManager _connection)
        {
            query_str = "insert_schedules()";
 	         return base.run(_connection);
        }
    }
}

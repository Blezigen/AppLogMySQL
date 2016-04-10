﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    class IQuery_Insert_in_schedule : BasicInsertQuery
    {
        public override bool run(MySQLManager _connection)
        {
            query_str = "insert_in_schedule()";
 	         return base.run(_connection);
        }
    }
}

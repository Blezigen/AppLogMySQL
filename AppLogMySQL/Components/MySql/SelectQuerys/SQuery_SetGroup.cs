using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_SetGroup : BasicSetQuery
    {
        public string SelectedGroup;
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("selectGroup({0})", SelectedGroup);
 	         return base.run(_connection);
        }
    }
}

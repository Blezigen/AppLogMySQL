using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_Get_Affordable_Discipline_By_Group : BasicSelectQuery
    {
        public override bool run(MySQLManager _connection)
        {
            query_str = "get_affordable_discipline_by_specialization()";
            return base.run(_connection);
        }
    }
}

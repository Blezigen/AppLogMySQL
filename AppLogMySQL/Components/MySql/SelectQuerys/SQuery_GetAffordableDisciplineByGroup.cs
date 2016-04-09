using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_GetAffordableDisciplineByGroup : BasicSelectQuery
    {
        public override bool run(MySQLManager _connection)
        {
            query_str = "get_affordable_discipline_by_group()";
            return base.run(_connection);
        }

        public override Dictionary<string, object> getFormatData()
        {
            var returnData = new Dictionary<string, object>();
            foreach (DataRow row in answerData.Rows)
            {
                returnData.Add(row["id_d"].ToString(),row["discipline_name"].ToString());
            }
            return returnData;
        }
    }
}

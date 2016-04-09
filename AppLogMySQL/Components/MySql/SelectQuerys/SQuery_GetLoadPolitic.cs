using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_GetLoadPolitic : BasicSelectQuery
    {
        public override bool run(MySQLManager _connection)
        {
            query_str = "get_load_politic()";
            return base.run(_connection);
        }
        public override Dictionary<string, object> getFormatData()
        {
            var returnData = new Dictionary<string, object>();
            foreach (DataRow row in answerData.Rows)
            {
                returnData.Add(row["id"].ToString(), row["name"].ToString());
            }
            return returnData;
        }
    }
}

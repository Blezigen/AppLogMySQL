using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_Get_Disciplines : BasicSelectQuery
    {

        public override Dictionary<string, object> getFormatData()
        {
            var returnData = new Dictionary<string, object>();
            foreach (DataRow row in answerData.Tables[0].Rows)
            {
                foreach (DataColumn column in answerData.Tables[0].Columns)
                {
                    returnData[row["id"].ToString()] = row["name"].ToString();
                }
            }
            return returnData;
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = "get_disciplines()";
            return base.run(_connection);
        }
    }
}

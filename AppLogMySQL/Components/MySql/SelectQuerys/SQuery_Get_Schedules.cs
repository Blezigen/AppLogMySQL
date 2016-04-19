﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_Get_Schedules : BasicSelectQuery
    {
        public override bool run(MySQLManager _connection)
        {
            query_str = "get_schedules()";
            return base.run(_connection);
        }
        public override Dictionary<string, object> getFormatData()
        {
            var returnData = new Dictionary<string, object>();
            foreach (DataRow row in answerData.Tables[0].Rows)
            {
                foreach (DataColumn column in answerData.Tables[0].Columns)
                {
                    if (!returnData.ContainsKey(row["day"].ToString()))
                    {
                        Dictionary<string, object> rowa = new Dictionary<string, object>();
                        rowa[row["para"].ToString()] = row["discipline"].ToString();
                        returnData[row["day"].ToString()] = rowa;
                    }
                    else
                    {

                        IDictionary rowa = (IDictionary)returnData[row["day"].ToString()];
                        rowa[row["para"].ToString()] = row["discipline"].ToString();
                    }
                }
            }
            return returnData;
        }
    }
}

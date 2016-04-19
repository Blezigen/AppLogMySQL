using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AppLogMySQL.Components.MySql;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    abstract class BasicSelectQuery
    {
        protected string query_str;
        protected DataSet answerData;

        public virtual Dictionary<string, object> getFormatData()
        {
            var returnData = new Dictionary<string, object>();
            foreach (DataColumn column in answerData.Tables[0].Columns)
            {
                returnData[column.ColumnName] = answerData.Tables[0].Rows[0][column.ColumnName];
            }
            return returnData;
        }
        public DataSet dataset
        {
            get
            {
                return answerData;
            }
        }
        public virtual bool run(MySQLManager _connection)
        {
            try
            {
                answerData = _connection.sqlQueryGetData(query_str);
                #if (DEBUG)
                    Console.WriteLine(string.Format("{0} run {1}", query_str,true));
                #endif
                return true;
            }
            catch (Exception e)
            {
                #if (DEBUG)
                    Console.WriteLine(string.Format("{0} run {1}", query_str, false));
                #endif
                if (e.Message == "FALSE PERMISION")
                {
                    throw new Exception("У приложения нет доступа!!!");
                }
                return false;
            }
            finally { }
        }
    }
}

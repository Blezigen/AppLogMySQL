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
        protected DataTable answerData;

        public virtual Dictionary<string, object> getFormatData()
        {
            var returnData = new Dictionary<string, object>();
            foreach (DataColumn column in answerData.Columns)
            {
                returnData[column.ColumnName] = answerData.Rows[0][column.ColumnName];
            }
            return returnData;
        }

        public virtual bool run(MySQLManager _connection)
        {
            try
            {
                answerData = _connection.sqlQueryGetData(query_str);
                return true;
            }
            catch (Exception e) {
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

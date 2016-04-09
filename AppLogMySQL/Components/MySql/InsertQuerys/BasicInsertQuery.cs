using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    abstract class BasicInsertQuery
    {
        protected string query_str;

        public virtual bool run(MySQLManager _connection)
        {
            try
            {
                return _connection.sqlQuerySetData(query_str);
            }
            catch (Exception e)
            {
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

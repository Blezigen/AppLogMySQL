using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AppLogMySQL.Components.MySql;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    abstract class BasicSetQuery
    {
        protected string query_str;
        
        public virtual bool run(MySQLManager _connection)
        {
            try
            {
                return _connection.sqlQuerySetData(query_str);
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

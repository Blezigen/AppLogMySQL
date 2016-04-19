using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AppLogMySQL.Components.MySql;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    abstract class BasicSetQuery
    {
        protected string query_str;
        
        public virtual bool run(MySQLManager _connection)
        {
            try
            {
                bool success = _connection.sqlQuerySetData(query_str);
                #if (DEBUG)
                    Console.WriteLine(string.Format("{0} run {1}", query_str, success));
                #endif
                return success;
            }
            catch (Exception e) {
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

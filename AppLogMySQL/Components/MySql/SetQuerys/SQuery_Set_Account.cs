using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Account : BasicSetQuery
    {
        string _login;
        string _password;
        DataSet answerData;
        public string login{
            set {
                _login = value;
            }
        }
        public DataSet dataset
        {
            get
            {
                return answerData;
            }
        }
        public string password
        {
            set
            {
                _password = value;
            }
        }

        public virtual Dictionary<string, object> getFormatData()
        {
            var returnData = new Dictionary<string, object>();
            foreach (DataColumn column in answerData.Tables[0].Columns)
            {
                returnData[column.ColumnName] = answerData.Tables[0].Rows[0][column.ColumnName];
            }
            return returnData;
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = String.Format("call set_account('{0}','{1}')", _login, _password);

            try
            {
                answerData = _connection.sqlQueryGetData(query_str);
                #if (DEBUG)
                    Console.WriteLine(string.Format("Set Account [TRUE]"));
                #endif
                return true;
            }
            catch (Exception e)
            {
                #if (DEBUG)
                    Console.WriteLine(string.Format("Set Account [FALSE]"));
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

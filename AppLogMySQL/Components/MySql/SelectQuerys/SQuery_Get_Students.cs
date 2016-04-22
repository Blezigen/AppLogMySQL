using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_Get_Students : BasicSelectQuery
    {
        string code = "normal";
        public string Filter {
            get {
                return code;
            }
            set {
                code = value;
            }
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("get_students('{0}')",code);
            return base.run(_connection);
        }
    }
}

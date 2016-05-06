using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Student : BasicSetQuery
    {
        int _student;

        public int Student{
            set {
                _student = value;
            }
            get
            {
                return _student;
            }
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("set_student({0})", _student);
 	        return base.run(_connection);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Teacher : BasicSetQuery
    {
        private int teacher;
        public SQuery_Set_Teacher(int _teacher) {
            this.teacher = _teacher;
        }
        public int Teacher {
            set {
                teacher = value;
            }
            get
            {
                return teacher;
            }
        }
        public override bool run(MySQLManager _connection) {
            query_str = string.Format("set_teacher({0})", this.teacher);
 	        return base.run(_connection);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Curriculum : BasicSetQuery
    {
        private int vars;
        public SQuery_Set_Curriculum(int _id)
        {
            this.vars = _id;
        }
        public int Curriculum
        {
            set
            {
                vars = value;
            }
            get
            {
                return vars;
            }
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("set_curriculumb({0})", this.vars);
 	        return base.run(_connection);
        }
    }
}

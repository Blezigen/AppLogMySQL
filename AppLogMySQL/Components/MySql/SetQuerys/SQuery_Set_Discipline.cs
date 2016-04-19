using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Discipline : BasicSetQuery
    {
        private int discipline;
        public SQuery_Set_Discipline(int _discipline)
        {
            this.discipline = _discipline;
        }
        public int Discipline
        {
            set
            {
                discipline = value;
            }
            get
            {
                return discipline;
            }
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("set_discipline({0})", this.discipline);
 	        return base.run(_connection);
        }
    }
}

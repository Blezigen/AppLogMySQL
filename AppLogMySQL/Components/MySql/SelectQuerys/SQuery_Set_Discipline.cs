using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SelectQuerys
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
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("select_discipline({0})", this.discipline);
 	         return base.run(_connection);
        }
    }
}

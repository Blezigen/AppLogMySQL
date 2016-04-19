using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Group : BasicSetQuery
    {
        private int group;
        public SQuery_Set_Group(int _group)
        {
            this.group = _group;
        }

        public int Group {
            set
            {
                group = value;
            }
            get
            {
                return group;
            }
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("set_group({0})", group);
 	        return base.run(_connection);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Log_Month : BasicSetQuery
    {
        private int val;
        public int Month
        {
            set
            {
                val = value;
            }
            get
            {
                return val;
            }
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("set_log_month({0})", val);
 	        return base.run(_connection);
        }
    }
}

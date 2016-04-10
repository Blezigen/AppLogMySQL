using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_WeekDay : BasicSetQuery
    {
        private int weekday;
        public SQuery_Set_WeekDay(int _weekday)
        {
            this.weekday = _weekday;
        }
        public int Weekday
        {
            set
            {
                weekday = value;
            }
            get
            {
                return weekday;
            }
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("select_weekday({0})", this.weekday);
 	         return base.run(_connection);
        }
    }
}

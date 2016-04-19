using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace AppLogMySQL.Components.MySql.SelectQuerys
{
    class SQuery_Get_Log : BasicSelectQuery
    {
        private int _year;
        private int _month;

        public int Year {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
            }
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("get_log({0},{1})",_year,_month);
            return base.run(_connection);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Curator : BasicSetQuery
    {
        int _value;

        public int Curator{
            set {
                _value = value;
            }
            get
            {
                return _value;
            }
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("set_curator({0})", _value);
 	        return base.run(_connection);
        }
    }
}

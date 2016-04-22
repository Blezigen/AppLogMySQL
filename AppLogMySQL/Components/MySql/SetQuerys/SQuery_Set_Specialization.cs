using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Specialization : BasicSetQuery
    {
        int _specialization;

        public int Specialization{
            set {
                _specialization = value;
            }
            get
            {
                return _specialization;
            }
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("set_specialization({0})", Specialization);
 	        return base.run(_connection);
        }
    }
}

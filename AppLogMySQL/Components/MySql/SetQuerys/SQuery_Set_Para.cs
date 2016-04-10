using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.SetQuerys
{
    class SQuery_Set_Para : BasicSetQuery
    {
        private int para;
        public SQuery_Set_Para(int _para)
        {
            this.para = _para;
        }
        public int Para
        {
            set
            {
                para = value;
            }
            get
            {
                return para;
            }
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("select_para({0})", this.para);
 	         return base.run(_connection);
        }
    }
}

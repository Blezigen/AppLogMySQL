using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    class IQuery_Insert_Curriculumb_Part_Discipline : BasicInsertQuery
    {
        int _checked;
        public void Set_Insert_Data(int Checked)
        {
            this._checked = Checked;
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("insert_curriculumb_part({0})", _checked);
 	         return base.run(_connection);
        }
    }
}

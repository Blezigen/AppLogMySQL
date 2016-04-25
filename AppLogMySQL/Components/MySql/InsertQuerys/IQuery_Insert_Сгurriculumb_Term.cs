using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    class IQuery_Insert_Сгurriculumb_Term : BasicInsertQuery
    {
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("insert_term_curriculumb()");
 	         return base.run(_connection);
        }
    }
}

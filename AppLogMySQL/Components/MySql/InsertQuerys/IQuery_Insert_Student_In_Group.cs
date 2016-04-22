using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    class IQuery_Insert_Student_In_Group : BasicInsertQuery
    {
        private string _account_student;
        private string _codes;

        public void Set_Insert_Data(string acc, string code) {
            this._account_student = acc;
            this._codes = code;
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("insert_student_into_group({0},{1})", _account_student, _codes);
 	        return base.run(_connection);
        }
    }
}

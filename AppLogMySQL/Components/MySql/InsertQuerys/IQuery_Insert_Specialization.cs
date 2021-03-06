﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    class IQuery_Insert_Specialization : BasicInsertQuery
    {
        private string _code;
        private string _name;

        public void Set_Insert_Data(string code, string name) {
            this._code = code;
            this._name = name;
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Title_name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("insert_specialization('{0}','{1}')", _code, _name);
 	         return base.run(_connection);
        }
    }
}

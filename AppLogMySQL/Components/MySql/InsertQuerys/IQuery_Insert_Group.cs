using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    class IQuery_Insert_Group : BasicInsertQuery
    {
        private string _name;
        private int _specialization;
        private int _curator;

        public void Set_Insert_Data(string name, int specialization, int curator) {
            this._name = name;
            this._specialization = specialization;
            this._curator = curator;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Specialization
        {
            get { return _specialization; }
            set { _specialization = value; }
        }

        public int Curator
        {
            get { return _curator; }
            set { _curator = value; }
        }

        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format("insert_group('{0}',{1},{2})", _name, _specialization, _curator);
 	         return base.run(_connection);
        }
    }
}

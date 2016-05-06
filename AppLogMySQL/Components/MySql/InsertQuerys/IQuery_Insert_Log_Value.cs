using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    public enum Log_Val 
    {
        Val_1 = 1,
        Val_2 = 2,
        Val_3 = 3,
        Val_4 = 4,
        Val_5 = 5,
        Val_ill = 6,
        Val_tht = 7,
        Val_not = 8,
        Val_clear = 0
    }

    class IQuery_Insert_Log_Value : BasicInsertQuery
    {

        Log_Val _value;
        int _day;

        public Log_Val Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
            }
        }


        public void Set_Insert_Data(int d,  Log_Val lv)
        {
            _value = lv;
            _day = d;
        }
        public override bool run(MySQLManager _connection)
        {
            switch (_value) {
                case Log_Val.Val_ill: query_str = string.Format("insert_log_value({0},'Б')", _day); break;
                case Log_Val.Val_not: query_str = string.Format("insert_log_value({0},'Н')", _day); break;
                case Log_Val.Val_tht: query_str = string.Format("insert_log_value({0},'У')", _day); break;
                case Log_Val.Val_1: query_str = string.Format("insert_log_value({0},'{1}')", _day, "1"); break;
                case Log_Val.Val_2: query_str = string.Format("insert_log_value({0},'{1}')", _day, "2"); break;
                case Log_Val.Val_3: query_str = string.Format("insert_log_value({0},'{1}')", _day, "3"); break;
                case Log_Val.Val_4: query_str = string.Format("insert_log_value({0},'{1}')", _day, "4"); break;
                case Log_Val.Val_5: query_str = string.Format("insert_log_value({0},'{1}')", _day, "5"); break;
                default: query_str = string.Format("insert_log_value({0},'C')", _day); break;
            }
 	        return base.run(_connection);
        }
    }
}

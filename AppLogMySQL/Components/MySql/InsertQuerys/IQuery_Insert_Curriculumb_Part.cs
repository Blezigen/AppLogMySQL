using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogMySQL.Components.MySql.InsertQuerys
{
    class IQuery_Insert_Curriculumb_Part : BasicInsertQuery
    {
        int count_lectures = 0; 
		int count_workexp = 0;
		int count_selfwork = 0;
		bool cred_term = false;
        bool exam_term = false;

        public int Count_Lection
        {
            get { return count_lectures; }
            set { count_lectures = value; }
        }

        public int Count_HomeWork
        {
            get { return count_workexp; }
            set { count_workexp = value; }
        }

        public int Count_SelfWork
        {
            get { return count_selfwork; }
            set { count_selfwork = value; }
        }

        public bool Has_Credit
        {
            get { return cred_term; }
            set { cred_term = value; }
        }

        public bool Has_Exam
        {
            get { return exam_term; }
            set { exam_term = value; }
        }

        public void Set_Insert_Data(int l, int w, int s, bool c, bool e)
        {
            count_lectures = l;
            count_workexp = w;
            count_selfwork = s;
            cred_term = c;
            exam_term = e;
        }
        public override bool run(MySQLManager _connection)
        {
            query_str = string.Format(
                "edit_curriculum_part({0},{1},{2},b'{3}',b'{4}')", 
                count_lectures, 
		        count_workexp,
		        count_selfwork,
		        Convert.ToInt32(cred_term),
                Convert.ToInt32(exam_term)
            );
 	        return base.run(_connection);
        }
    }
}

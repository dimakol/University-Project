using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Lecturer : Employee
    {
        Database db = Database.Instance();

        private List<Course> Courses;

        public Lecturer()
        {
            Courses = new List<Course>(10);
            MyJob();
            MySalary();
        }

        public override void MySalary()
        {
            SALARY = Finance.Salary(this.JOB);
        }

        public override void MyJob()
        {
            JOB = Job.Lect;
        }

        public override void decrypt_courses(String course_code)
        {
            List<String> cnums = course_code.Split('#').ToList();
            foreach (String value in cnums)
            {
                if (value != "") Courses.Add(db.getCourse(value));
            }
        }

        public String encrypt_courses()
        {
            String code = "";
            foreach (Course value in Courses)
            {
                code += value.CNUM + '#';
            }
            return code;
        }

        public List<Course> COURSES
        {
            get { return Courses; }
            set { Courses = value; }
        }
    }
}

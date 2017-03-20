using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Tutor : Employee
    {
        Database db = Database.Instance();
        private List<Course> Courses;

        public Tutor()
        {
            Courses = new List<Course>(10);
            MyJob();
            MySalary();
        }

        public override void MySalary()
        {
            SALARY = Finance.Salary(this.JOB); ;
        }

        public override void MyJob()
        {
            JOB = Job.Tut;
        }

        public override void decrypt_courses(String course_code)
        {
            List<String> cnums = course_code.Split('#').ToList();
            foreach (String value in cnums)
            {
                if (value != "") Courses.Add(db.getCourse(value));
            }
        }

        public List<Course> COURSES
        {
            get { return Courses; }
            set { Courses = value; }
        }
    }
}

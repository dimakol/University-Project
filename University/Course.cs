using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Course
    {
        Database db = Database.Instance();

        private String cNum;
        private String cName;
        private Year year;
        private Semester sem;
        private Department dept;
        private float Grade;
        private float Points;
        private List<Course> Pre;

        public Course()
        {
            Pre = new List<Course>(10);
        }

        public void decrypt_courses(String course_code)
        {
            List<String> cnums = course_code.Split('#').ToList();
            foreach (String value in cnums)
            {
                if (value != "") Pre.Add(db.getCourse(value));
            }
        }

        //GETTERS + SETTERS
        public String CNUM
        {
            get { return cNum; }
            set { cNum = value; }
        }
        public String CNAME
        {
            get { return cName; }
            set { cName = value; }
        }
        public Year YEAR
        {
            get { return year; }
            set { year = value; }
        }
        public Semester SEMESTER
        {
            get { return sem; }
            set { sem = value; }
        }
        public float GRADE
        {
            get { return Grade; }
            set { Grade = value; }
        }
        public float POINTS
        {
            get { return Points; }
            set { Points = value; }
        }
        public List<Course> PRE
        {
            get { return Pre; }
            set { Pre = value; }
        }
        public String SDEPT()
        {
            String str = "Undefined";
            int num = (int)dept;
            switch (num)
            {
                case 1:
                    str = "Software";
                    break;

                case 2:
                    str = "Electronic";
                    break;

                case 3:
                    str = "Civil";
                    break;

                case 4:
                    str = "Chemistry";
                    break;

                case 5:
                    str = "Industrial-Management";
                    break;

                case 6:
                    str = "Machines";
                    break;
            }
            return str;
        }       //returns department as a string
        public Department DEPT
        {
            get { return dept; }
            set { dept = value; }
        }
    }
}

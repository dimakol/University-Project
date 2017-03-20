using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student : Person
    {
        Database db = Database.Instance();

        private float Average;
        private List<Book> Books;
        private List<Course> Courses;
        private List<Course> Grades;
        private Boolean State;
        private Year year;
        private Semester sem;

        public Student()
        {            
            Average = 0.0f;
            State = true;
            Books = new List<Book>();
            Courses = new List<Course>();
            Grades = new List<Course>();
            year = Year.One;
            sem = Semester.One;
        }


        public float calc_avg()
        {
            float sum = 0, pts = get_pts(true);
            foreach (Course value in Grades)
            {
                sum += value.GRADE * value.POINTS;
            }
            Average = sum / Math.Max(pts, 1);
            return (float)Math.Round(Average, 2);
        }

        public override void decrypt_courses(String course_code)
        {
            List<String> cnums = course_code.Split('#').ToList();
            foreach (String value in cnums)
            {
                if (value != "") Courses.Add(db.getCourse(value));
            }
        }

        public void decrypt_grades(String grade_code)
        {
            List<String> cnums = grade_code.Split('#').ToList();
            foreach (String value in cnums)
            {
                if (value != "")
                {
                    List<String> grades = value.Split('$').ToList();
                    Grades.Add(db.getCourse(grades[0]));
                    Grades[Grades.Count - 1].GRADE = Convert.ToSingle(grades[1]);
                }
            }
        }

        public String encrypt_books(List<String> bnums)
        {
            String code = "";
            foreach (String value in bnums)
            {
                code += value + "#";
            }
            return code;
        }

        public virtual void decrypt_books(String book_code)
        {
            Books = new List<Book>();
            List<String> bnums = book_code.Split('#').ToList();
            foreach (String value in bnums)
            {
                if (value != "") Books.Add(db.getBook(value));
            }
        }

        public void Advance()
        {
            if (sem == Semester.One)
            {
                sem = Semester.Two;
            }

            else
            {
                sem = Semester.One;
                year++;
            }
        }

        //Getters + Setters
        public float AVERAGE
        {
            get { return Average; }
            set { Average = value; }
        }
        public Boolean STATE
        {
            get { return State; }
            set { State = value; }
        }
        public List<Course> COURSES
        {
            get { return Courses; }
            set { Courses = value; }
        }
        public List<Book> BOOKS
        {
            get { return Books; }
            set { Books = value; }
        }
        public List<Course> GRADES
        {
            get { return Grades; }
            set { Courses = value; }
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
        public float get_pts(Boolean mode)  //true for all, false for passed only
        {
            float num = 0;
            foreach(Course value in Grades)
            {
                if (mode == false)
                {
                    if (value.GRADE >= 56)
                        num += value.POINTS;
                }
                else num += value.POINTS;
            }
            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    abstract public class Employee : Person
    {
        private float Salary;
        private Degree deg;
        private Job role;

        public virtual void MySalary() { }
        public virtual void MyJob() { }


        // Default Constructor
        public Employee()
            : base() 
        {
            this.Salary = 0;
            this.role = Job.UND;
        }

        // Getters + Setters
        public float SALARY
        {
            get { return Salary; }
            set { Salary = value; }
        }
        public Degree DEGREE 
        {
            get { return deg; }
            set { deg = value; }
        }
        public String SDEGREE()
        {
            String s = "";
            switch ((int)deg)
            {
                case 0:
                case 1:
                case 2:
                    s = SGENDER();
                    break;

                case 3:
                    s = "Dr.";
                    break;
            }
            return s;
        }
        public Job JOB
        {
            get { return role; }
            set { role = value; }
        }
    }
}

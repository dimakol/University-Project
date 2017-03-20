using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public enum Year { One = 1, Two, Three, Four };
    public enum Semester { One = 1, Two };
    public enum Day { UND = 0, Sunday, Monday, Tuesday, Wedensday, Thursday, Friday, Saturday };
    public enum Department { UND = 0, SE, EE, CE, CHE, IME, ME };     //Software, Electronic, Civil, Chemistry, Industrial-Management, Machines
    public enum Gender { UND = 0, Male, Female };
    public enum Job { UND = 0, Sec, Tut, Lect, HoaD };   //TO DO
    public enum Degree { UND = 0, BSc, MSc, PhD };

    abstract public class Person
    {

        Database db = Database.Instance();

        private String fName;
        private String lName;
        private String userName;
        private String passWord;
        private String id;
        private String Phone;
        private String Mail;
        private Department dept;
        private Gender gen;
        
        // Default Constructor
        public Person()
        {
            this.fName = "Undefined";
            this.lName = "Undefined";
            this.userName = "Undefined";
            this.passWord = "Undefined";
            this.id = "Undefined";
            this.Phone = "Undefined";
            this.Mail = "Undefined";
            this.dept = Department.UND;
            this.gen = Gender.UND;
        }

        public virtual void decrypt_courses(String course_code) { }

        // Getters + Setters
        public String FIRSTNAME
        {
            get { return fName; }
            set { fName = value; }
        }
        public String LASTNAME
        {
            get { return lName; }
            set { lName = value; }
        }
        public String USERNAME
        {
            get { return userName; }
            set { userName = value; }
        }
        public String PASSWORD
        {
            get { return passWord; }
            set { passWord = value; }
        }
        public String ID
        {
            get { return id; }
            set { id = value; }
        }
        public String PHONE
        {
            get { return Phone; }
            set { Phone = value; }
        }
        public String MAIL
        {
            get { return Mail; }
            set { Mail = value; }
        }
        public String SDEPT()
        {
            String str = "Undefined";
            switch ((int)dept)
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
        public Gender GENDER
        {
            get { return gen; }
            set { gen = value; }
        }
        public String SGENDER()
        {
            String s = "";
            switch ((int)gen)
            {
                case 1:
                    s = "Mr.";
                    break;

                case 2:
                    s = "Mrs.";
                    break;
            }
            return s;
        }
    }
}

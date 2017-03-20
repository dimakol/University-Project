using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace University
{
    class Database
    {
        private static Database db; //singleton
        private String connetionString = null;
        private SqlConnection con;
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;
        private SqlDataAdapter sda;

        private const String TCourse = "Courses";
        private const String TPerson = "Person";
        private const String TStudent = "Student";
        private const String TEmployee = "Employee";
        private const String TAdmission = "Admission";
        private const String TReceptionHours = "ReceptionHours";
        private const String TLibrary = "Library";
        private const String TGraduates = "Graduates";

        //private Factory userFactory;
        private Person user;    //the current logged in user


        //Methods------------------------------------------------------------------------------------------------------------//
        //PRIVATE
        private Database() // ctor
        {
            //connetionString = Properties.Settings.Default.UniversityConnectionString;
            con = new SqlConnection(connetionString);
            cmd = new SqlCommand("");
        }

        private Boolean OpenConn()   //tries to open a connection, if fails an error message is displayed
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nCan't open connection!", "Error");
                    return false;
                }
            }
            return false;
        }
        private void CloseConn()     //closes the connection if it isn't closed
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }

        }
        private void setCom(String command)  //sets the sent string as the current command
        {
            cmd = new SqlCommand(command, con);
        }


        //PUBLIC
        public static Database Instance()   //creates a new db if none exist, or returns the current existing one
        {
            if (db == null)
            {
                db = new Database();
            }
            return db;
        }

        public Boolean checkExistance(String TableName, String Conditions)     //checks if something exists in Database, returns True if it does
        {
            String query = "SELECT * FROM " + TableName + " WHERE " + Conditions;
            OpenConn();
            setCom(query);
            SqlDataReader dbr = cmd.ExecuteReader();
            int count = 0;
            while (dbr.Read())
            {
                ++count;    //counts how many 
            }
            CloseConn();
            return (count != 0);    //if not 0, means it exists
        }

        public int Login(String username, String password)
        {
            int type = -1;
            String Conditions = "username = '" + username + "' AND password = '" + password + "'";
            List<String> itemList = new List<String>();

            if (!checkExistance(TPerson, Conditions)) return type;

            itemList = FetchList(TPerson, "type", Conditions);
            type = Convert.ToInt32(itemList[0]);

            try   //in case there is a problem in db, an exception is thrown and -2 is returned
            {
                switch (type)
                {
                    case 0: //student
                        user = getStudent(Conditions);
                        break;

                    case 1: //secretary                           
                    case 2: //tutor
                    case 3: //lecturer
                    case 4: //head of department
                        user = getEmployee(Conditions);
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -2;
            }


            return type;
        }

        public Boolean register(String user, String pass, String id, String fname, String lname, String mail, String phon, int gen, int dept, int type)
        {
            String values = "'" + user + "','" + pass + "'," + id + ",'" + fname + "','" + lname + "','"
                                + mail + "','" + phon + "'," + gen + "," + dept + "," + type;

            if (checkExistance(TPerson, "id = " + id) || checkExistance(TGraduates, "id = " + id))    //if found id in database
            {
                MessageBox.Show("ID already taken!\nPlease make sure this ID is yours.", "Error");
                return false;
            }
            if (checkExistance(TPerson, "username = '" + user + "'"))    //if found username in database
            {
                MessageBox.Show("Username already taken!\nPlease choose a different Username.", "Error");
                return false;
            }
            if (mail != "")    //if not empty mail
                if (db.checkExistance(TPerson, "email = '" + mail + "'"))    //if found email in database
                {
                    MessageBox.Show("E-Mail already taken!\nPlease choose a different address.", "Error");
                    return false;
                }

            return Factory.Create(type, values, id);
        }

        public void RecoverPass(String ID)
        {
            Student stud = getStudent("id = " + ID);

        }

        public Boolean CheckCourse(String cnum)     //true if any student still has this course, otherwise false
        {
            dt = new DataTable();
            dt = FetchTable(TStudent, "*", "Courses LIKE '%" + cnum + "%'").Tables[TStudent];
            if (dt.Rows.Count > 0) return true;
            else return false;
        }


        //simple getters + setters
        public Person USER
        { 
            get { return user; }
            set { user = value; }
        }
        public String TPERSON { get { return TPerson; } }
        public String TCOURSE { get { return TCourse; } }
        public String TSTUDENT { get { return TStudent; } }
        public String TEMPLOYEE { get { return TEmployee; } }
        public String TADMISSION { get { return TAdmission; } }
        public String TLIBRARY { get { return TLibrary; } }
        public String TRECEPTION { get { return TReceptionHours; } }
        public String TGRADUATES { get { return TGraduates; } }

        //complex getters
        public List<String> FetchList(String TableName, String Fields, String Conditions)    //returns list of requested items, or null
        {
            List<String> list = null;
            String query = "SELECT " + Fields + " FROM " + TableName + " WHERE " + Conditions;
            if (OpenConn())
            {
                list = new List<String>();
                ds = new DataSet();
                sda = new SqlDataAdapter();

                setCom(query);
                sda.SelectCommand = cmd;
                sda.Fill(ds, TableName);
                CloseConn();

                for (int i = 0; i < ds.Tables[0].Rows[0].ItemArray.Length; i++)
                {
                    list.Add(ds.Tables[0].Rows[0].ItemArray[i].ToString());
                }
            }
            return list;
        }
        public DataSet FetchTable(String TableName, String Fields, String Conditions)
        {
            String query = "SELECT " + Fields + " FROM " + TableName + " WHERE " + Conditions;
            dt = new DataTable();
            ds = new DataSet();
            sda = new SqlDataAdapter();

            OpenConn();
            setCom(query);
            sda.SelectCommand = cmd;
            sda.Fill(ds, TableName);
            CloseConn();

            return ds;
        }
        public Student getStudent(String Conditions)
        {
            List<String> itemList = new List<String>();
            Student _stud = new Student();

            itemList = FetchList(TPerson, "*", Conditions);

            _stud.USERNAME = itemList[0];
            _stud.PASSWORD = itemList[1];
            _stud.ID = itemList[2];
            _stud.FIRSTNAME = itemList[3];
            _stud.LASTNAME = itemList[4];
            _stud.MAIL = itemList[5];
            _stud.PHONE = itemList[6];

            _stud.GENDER = (Gender)(Convert.ToInt32(itemList[7]));
            _stud.DEPT = (Department)(Convert.ToInt32(itemList[8]));

            //-------------------------------------------------------------------------------------------//
            itemList = FetchList(TStudent, "*", "id = " + _stud.ID);
            //-------------------------------------------------------------------------------------------//
            _stud.AVERAGE = Convert.ToSingle(itemList[1]);
            _stud.STATE = Convert.ToBoolean(itemList[2]);
            _stud.decrypt_books(itemList[3]);
            _stud.decrypt_courses(itemList[4]);
            _stud.decrypt_grades(itemList[5]);
            _stud.YEAR = (Year)(Convert.ToInt32(itemList[6]));
            _stud.SEMESTER = (Semester)(Convert.ToInt32(itemList[7]));
            return _stud;

        }
        public Employee getEmployee(String Conditions)
        {
            Employee _emp = null;
            List<String> itemList = new List<String>();

            itemList = FetchList(TPerson, "*", Conditions);

            switch (Convert.ToInt32(itemList[9]))
            {

                case 1: //secretary
                    Secretary _sec = new Secretary();

                    _sec.USERNAME = itemList[0];
                    _sec.PASSWORD = itemList[1];
                    _sec.ID = itemList[2];
                    _sec.FIRSTNAME = itemList[3];
                    _sec.LASTNAME = itemList[4];
                    _sec.MAIL = itemList[5];
                    _sec.PHONE = itemList[6];

                    _sec.GENDER = (Gender)(Convert.ToInt32(itemList[7]));
                    _sec.DEPT = (Department)(Convert.ToInt32(itemList[8]));
                    //-------------------------------------------------------------------------------------------//
                    itemList = FetchList(TEmployee, "*", "id = " + _sec.ID);
                    //-------------------------------------------------------------------------------------------//
                    _sec.SALARY = Convert.ToSingle(itemList[1]);
                    _sec.DEGREE = (Degree)(Convert.ToInt32(itemList[3]));
                    _sec.JOB = (Job)(Convert.ToInt32(itemList[4]));

                    _emp = _sec;
                    break;

                case 2: //tutor
                    Tutor _tut = new Tutor();

                    _tut.USERNAME = itemList[0];
                    _tut.PASSWORD = itemList[1];
                    _tut.ID = itemList[2];
                    _tut.FIRSTNAME = itemList[3];
                    _tut.LASTNAME = itemList[4];
                    _tut.MAIL = itemList[5];
                    _tut.PHONE = itemList[6];

                    _tut.GENDER = (Gender)(Convert.ToInt32(itemList[7]));
                    _tut.DEPT = (Department)(Convert.ToInt32(itemList[8]));
                    //-------------------------------------------------------------------------------------------//
                    itemList = FetchList(TEmployee, "*", "id = " + _tut.ID);
                    //-------------------------------------------------------------------------------------------//
                    _tut.SALARY = Convert.ToSingle(itemList[1]);
                    _tut.decrypt_courses(itemList[2]);
                    _tut.DEGREE = (Degree)(Convert.ToInt32(itemList[3]));
                    _tut.JOB = (Job)(Convert.ToInt32(itemList[4]));

                    _emp = _tut;
                    break;

                case 3: //lecturer
                    Lecturer _lect = new Lecturer();

                    _lect.USERNAME = itemList[0];
                    _lect.PASSWORD = itemList[1];
                    _lect.ID = itemList[2];
                    _lect.FIRSTNAME = itemList[3];
                    _lect.LASTNAME = itemList[4];
                    _lect.MAIL = itemList[5];
                    _lect.PHONE = itemList[6];

                    _lect.GENDER = (Gender)(Convert.ToInt32(itemList[7]));
                    _lect.DEPT = (Department)(Convert.ToInt32(itemList[8]));
                    //-------------------------------------------------------------------------------------------//
                    itemList = FetchList(TEmployee, "*", "id = " + _lect.ID);
                    //-------------------------------------------------------------------------------------------//
                    _lect.SALARY = Convert.ToSingle(itemList[1]);
                    _lect.decrypt_courses(itemList[2]);
                    _lect.DEGREE = (Degree)(Convert.ToInt32(itemList[3]));
                    _lect.JOB = (Job)(Convert.ToInt32(itemList[4]));

                    _emp = _lect;
                    break;

                case 4: //dept head
                    HeadDept _hoad = new HeadDept();

                    _hoad.USERNAME = itemList[0];
                    _hoad.PASSWORD = itemList[1];
                    _hoad.ID = itemList[2];
                    _hoad.FIRSTNAME = itemList[3];
                    _hoad.LASTNAME = itemList[4];
                    _hoad.MAIL = itemList[5];
                    _hoad.PHONE = itemList[6];

                    _hoad.GENDER = (Gender)(Convert.ToInt32(itemList[7]));
                    _hoad.DEPT = (Department)(Convert.ToInt32(itemList[8]));
                    //-------------------------------------------------------------------------------------------//
                    itemList = FetchList(TEmployee, "*", "id = " + _hoad.ID);
                    //-------------------------------------------------------------------------------------------//
                    _hoad.SALARY = Convert.ToSingle(itemList[1]);
                    _hoad.DEGREE = (Degree)(Convert.ToInt32(itemList[3]));
                    _hoad.JOB = (Job)(Convert.ToInt32(itemList[4]));

                    _emp = _hoad;
                    break;
            }

            return _emp;
        }
        public Course getCourse(String CourseNumber)
        {
            Course c = new Course();
            List<String> itemList = new List<String>();

            itemList = FetchList(TCourse, "*", "Course_Number = " + CourseNumber);

            c.CNUM                                = itemList[0];
            c.CNAME                               = itemList[1];
            c.YEAR         = (Year)(Convert.ToInt32(itemList[2]));
            c.SEMESTER = (Semester)(Convert.ToInt32(itemList[3]));
            c.DEPT   = (Department)(Convert.ToInt32(itemList[4]));
            c.POINTS             = Convert.ToSingle(itemList[5]);
            c.decrypt_courses                      (itemList[6]);

            return c;
        }
        public Book getBook(String BookNumber)
        {
            Book b = new Book();
            List<String> itemList = new List<String>();

            itemList = FetchList(TLibrary, "*", "Book_Number = " + BookNumber);

            b.BNUM = Convert.ToInt32(itemList[0]);
            b.NAME = itemList[1];
            b.DEPT = (Department)(Convert.ToInt32(itemList[2]));
            b.AUTHOR = itemList[3];

            return b;
        }

        //complex setters
        public void AddToTable(String TableName, String Values)
        {
            String query = "INSERT INTO " + TableName + " VALUES (" + Values + ");";
            db.OpenConn();
            setCom(query);
            cmd.ExecuteNonQuery();
            db.CloseConn();
        }

        public void DeleteFromTable(String TableName,String Key, String KeyValues)
        {
            String query = "DELETE FROM " + TableName + " WHERE " + Key + "=" + KeyValues + ";";
            db.OpenConn();
            setCom(query);
            cmd.ExecuteNonQuery();
            db.CloseConn();
        }

        public void SimpleUpdate(String TableName, String NewFields, String Conditions)
        {
            String update_query = "UPDATE " + TableName + " SET " + NewFields + " WHERE " + Conditions;
            OpenConn();
            setCom(update_query);
            cmd.ExecuteNonQuery();
            CloseConn();
        }
        public DataTable UpdateTable(String TableName, String Fields, String Conditions, DataTable DT)
        {
            String query = "SELECT " + Fields + " FROM " + TableName + " WHERE " + Conditions;

            sda = new SqlDataAdapter();
            ds = new DataSet();

            OpenConn();
            setCom(query);
            sda.SelectCommand = cmd;
            sda.Fill(ds, TableName);
            sda.UpdateCommand = new SqlCommandBuilder(sda).GetUpdateCommand();
            sda.Update(DT);
            sda.InsertCommand = new SqlCommandBuilder(sda).GetInsertCommand();
            sda.Update(DT);
            CloseConn();

            return DT;
        }
        public void updateGrade(String id, String cnum, String grade)
        {
            List<String> itemList = new List<String>();
            Student stud = new Student();

            itemList = FetchList(TStudent, "*", "id = " + id);

            String courses = itemList[4];
            String grades = itemList[5];

            courses = courses.Remove(courses.IndexOf(cnum), cnum.Length + 1);
            grades += cnum + "$" + grade + "#";

            stud.decrypt_grades(grades);
            stud.calc_avg();

            SimpleUpdate(TStudent, "courses = '" + courses + "', grades = '" + grades + "', average = " + stud.AVERAGE, "id = " + id);

            stud = getStudent("id = " + id);

            DataTable gdt = FetchTable(TCourse, "Course_Number", "Accademic_Year = " + (int)stud.YEAR + " and Semester = " + (int)stud.SEMESTER + " and (Department = 0 or Department = " + (int)stud.DEPT + ")").Tables[TCourse];
            List<String> listok = new List<String>();
            for (int i = 0; i < gdt.Rows.Count; i++)
            {
                listok.Add(gdt.Rows[i].ItemArray[0].ToString());
            }

            for (int i = 0; i < listok.Count; i++)
            {
                Boolean flag = false;
                for (int j = 0; j < stud.GRADES.Count; j++)
                {
                    if (stud.GRADES[j].CNUM == listok[i])
                    {
                        flag = true;
                        break;
                    }               
                }
                if (flag == false)
                {
                    return;
                }
            }

            stud.Advance();
            SimpleUpdate(TStudent, "_year = " + (int)stud.YEAR + ", Semester = " + (int)stud.SEMESTER, "id = " + id);
        }

        public Boolean freezeStudent(String id)
        {
            int num = 0;
            List<String> itemList = new List<String>();

            itemList = FetchList(TStudent, "*", "id = " + id);

            if (itemList[0] == null) { return false; }

            if (!Convert.ToBoolean(itemList[2]))  //if state was 0, else it remains 0
            {
                num = 1;
            }

            SimpleUpdate(TStudent, "state = " + num, "id = " + id);

            return true;
        }

        //old
        //public int login(String query, Boolean mode)    // mode 0 for login, 1 for pass recovery
        //{
        //    int type;
        //    ds = new DataSet();
        //    sda = new SqlDataAdapter();

        //    if (!checkExistance(query)) return -1;

        //    setCom(query);
        //    sda.SelectCommand = cmd;
        //    sda.Fill(ds, "person");
        //    type = (Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[9]));

        //    try         //in case there is a problem in db, an exception is thrown and ex is returned
        //    {
        //        if (!mode)
        //            switch (type)
        //            {
        //                case 0: //student
        //                    Student _stud = new Student();

        //                    _stud.USERNAME = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        //                    _stud.PASSWORD = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        //                    _stud.ID = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        //                    _stud.FIRSTNAME = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        //                    _stud.LASTNAME = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //                    _stud.MAIL = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        //                    _stud.PHONE = ds.Tables[0].Rows[0].ItemArray[6].ToString();

        //                    _stud.GENDER = (Gender)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString()));
        //                    _stud.DEPT = (Department)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[8].ToString()));

        //                    //-------------------------------------------------------------------------------------------//
        //                    setCom("SELECT * FROM student WHERE id = " + _stud.ID);
        //                    sda.SelectCommand = cmd;
        //                    sda.Fill(ds, "student");
        //                    //-------------------------------------------------------------------------------------------//
        //                    _stud.AVERAGE = Convert.ToSingle(ds.Tables[1].Rows[0].ItemArray[1].ToString());
        //                    _stud.STATE = Convert.ToBoolean(ds.Tables[1].Rows[0].ItemArray[2].ToString());
        //                    _stud.decrypt_courses(ds.Tables[1].Rows[0].ItemArray[3].ToString());
        //                    _stud.decrypt_grades(ds.Tables[1].Rows[0].ItemArray[4].ToString());
        //                    _stud.YEAR = (Year)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[5].ToString()));
        //                    _stud.SEMESTER = (Semester)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[6].ToString()));

        //                    user = _stud;
        //                    break;

        //                case 1: //secretary
        //                    Secretary _sec = new Secretary();

        //                    _sec.USERNAME = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        //                    _sec.PASSWORD = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        //                    _sec.ID = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        //                    _sec.FIRSTNAME = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        //                    _sec.LASTNAME = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //                    _sec.MAIL = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        //                    _sec.PHONE = ds.Tables[0].Rows[0].ItemArray[6].ToString();

        //                    _sec.GENDER = (Gender)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString()));
        //                    _sec.DEPT = (Department)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[8].ToString()));
        //                    //-------------------------------------------------------------------------------------------//
        //                    setCom("SELECT * FROM employee WHERE id = " + _sec.ID);
        //                    sda.SelectCommand = cmd;
        //                    sda.Fill(ds, "employee");
        //                    //-------------------------------------------------------------------------------------------//
        //                    _sec.SALARY = Convert.ToSingle(ds.Tables[1].Rows[0].ItemArray[1].ToString());
        //                    _sec.DEGREE = (Degree)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[3].ToString()));
        //                    _sec.JOB = (Job)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[4].ToString()));

        //                    user = _sec;
        //                    break;

        //                case 2: //tutor
        //                    Tutor _tut = new Tutor();

        //                    _tut.USERNAME = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        //                    _tut.PASSWORD = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        //                    _tut.ID = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        //                    _tut.FIRSTNAME = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        //                    _tut.LASTNAME = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //                    _tut.MAIL = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        //                    _tut.PHONE = ds.Tables[0].Rows[0].ItemArray[6].ToString();

        //                    _tut.GENDER = (Gender)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString()));
        //                    _tut.DEPT = (Department)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[8].ToString()));
        //                    //-------------------------------------------------------------------------------------------//
        //                    setCom("SELECT * FROM employee WHERE id = " + _tut.ID);
        //                    sda.SelectCommand = cmd;
        //                    sda.Fill(ds, "employee");
        //                    //-------------------------------------------------------------------------------------------//
        //                    _tut.SALARY = Convert.ToSingle(ds.Tables[1].Rows[0].ItemArray[1].ToString());
        //                    //to do courses here
        //                    _tut.DEGREE = (Degree)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[3].ToString()));
        //                    _tut.JOB = (Job)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[4].ToString()));

        //                    user = _tut;
        //                    break;

        //                case 3: //lecturer
        //                    Lecturer _lect = new Lecturer();

        //                    _lect.USERNAME = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        //                    _lect.PASSWORD = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        //                    _lect.ID = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        //                    _lect.FIRSTNAME = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        //                    _lect.LASTNAME = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //                    _lect.MAIL = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        //                    _lect.PHONE = ds.Tables[0].Rows[0].ItemArray[6].ToString();

        //                    _lect.GENDER = (Gender)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString()));
        //                    _lect.DEPT = (Department)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[8].ToString()));
        //                    //-------------------------------------------------------------------------------------------//
        //                    setCom("SELECT * FROM employee WHERE id = " + _lect.ID);
        //                    sda.SelectCommand = cmd;
        //                    sda.Fill(ds, "employee");
        //                    //-------------------------------------------------------------------------------------------//
        //                    _lect.SALARY = Convert.ToSingle(ds.Tables[1].Rows[0].ItemArray[1].ToString());
        //                    _lect.decrypt_courses(ds.Tables[1].Rows[0].ItemArray[2].ToString());
        //                    _lect.DEGREE = (Degree)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[3].ToString()));
        //                    _lect.JOB = (Job)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[4].ToString()));

        //                    user = _lect;
        //                    break;

        //                case 4: //dept head
        //                    HeadDept _hoad = new HeadDept();

        //                    _hoad.USERNAME = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        //                    _hoad.PASSWORD = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        //                    _hoad.ID = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        //                    _hoad.FIRSTNAME = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        //                    _hoad.LASTNAME = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //                    _hoad.MAIL = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        //                    _hoad.PHONE = ds.Tables[0].Rows[0].ItemArray[6].ToString();

        //                    _hoad.GENDER = (Gender)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString()));
        //                    _hoad.DEPT = (Department)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[8].ToString()));
        //                    //-------------------------------------------------------------------------------------------//
        //                    setCom("SELECT * FROM employee WHERE id = " + _hoad.ID);
        //                    sda.SelectCommand = cmd;
        //                    sda.Fill(ds, "employee");
        //                    //-------------------------------------------------------------------------------------------//
        //                    _hoad.SALARY = Convert.ToSingle(ds.Tables[1].Rows[0].ItemArray[1].ToString());
        //                    //to do courses here
        //                    _hoad.DEGREE = (Degree)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[3].ToString()));
        //                    _hoad.JOB = (Job)(Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[4].ToString()));

        //                    user = _hoad;
        //                    break;

        //            }
        //        else
        //        {
        //            String info = "" + ds.Tables[0].Rows[0].ItemArray[1].ToString() +
        //                         "#" + ds.Tables[0].Rows[0].ItemArray[3].ToString() +
        //                         "#" + ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //            Gender gen = (Gender)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7].ToString()));
        //            send_mail(ds.Tables[0].Rows[0].ItemArray[5].ToString(), info, gen);
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        return -2;
        //    }

        //    return type;        //if no exception was thrown, returns account type
        //}
        //public String get_Admission(Department dept)
        //{
        //    ds = new DataSet();
        //    sda = new SqlDataAdapter();
        //    String query = "SELECT requirement from Admission where dept = " + (int)dept;
        //    setCom(query);
        //    sda.SelectCommand = cmd;
        //    sda.Fill(ds, "Admission");
        //    return ds.Tables[0].Rows[0].ItemArray[0].ToString();
        //}
        //public Student LoadStudent(Student _stud, String id)
        //{
        //    ds = new DataSet();
        //    sda = new SqlDataAdapter();

        //    //-------------------------------------------------------------------------------------------//
        //    setCom("SELECT * FROM student WHERE id = " + id);
        //    sda.SelectCommand = cmd;
        //    sda.Fill(ds, "student");
        //    //-------------------------------------------------------------------------------------------//
        //    _stud.AVERAGE = Convert.ToSingle(ds.Tables[0].Rows[0].ItemArray[1].ToString());
        //    _stud.STATE = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[2].ToString());
        //    _stud.decrypt_courses(ds.Tables[0].Rows[0].ItemArray[3].ToString());
        //    _stud.decrypt_grades(ds.Tables[0].Rows[0].ItemArray[4].ToString());
        //    _stud.YEAR = (Year)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[5].ToString()));
        //    _stud.SEMESTER = (Semester)(Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[6].ToString()));


        //    return _stud;
        //}
        //public void update_person(String fname, String lname, String phone, String mail, String id)
        //{
        //    String query = "UPDATE person SET firstname = '" + fname + "', lastname = '" + lname +
        //       "', phone = '" + phone + "', email = '" + mail + "' WHERE id = " + id;

        //    OpenConn();
        //    setCom(query);
        //    cmd.ExecuteNonQuery();
        //    CloseConn();

        //    //update user in real time
        //    user.FIRSTNAME = fname;
        //    user.LASTNAME = lname;
        //    user.PHONE = phone;
        //    user.MAIL = mail;
        //}
    }
}

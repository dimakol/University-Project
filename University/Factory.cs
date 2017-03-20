using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    static class Factory
    {
        static Database db = Database.Instance();
  
        public static Boolean Create(int type, String values, String id)
        {

            db.AddToTable(db.TPERSON, values);

            Employee _user;

            switch (type)
            {
                case 0: //student
                    values = id + ", 0.0, 1, '', '', '', 1, 1";   //default student values
                    db.AddToTable(db.TSTUDENT, values);
                    break;

                case 1: //secretary
                    _user = new Secretary();
                    values = id + ", " + _user.SALARY + ", null, 0, " + type;   //default secretary values
                    db.AddToTable(db.TEMPLOYEE, values);
                    break;

                case 2: //tutor
                    _user = new Tutor();
                    values = id + ", " + _user.SALARY + ", null, 1, " + type;   //default tutor values
                    db.AddToTable(db.TEMPLOYEE, values);
                    db.AddToTable(db.TRECEPTION, id + ", '1', '2015-05-26 00:00:00.000', '2015-05-26 00:00:00.000'");
                    break;

                case 3: //lecturer
                    _user = new Lecturer();
                    values = id + ", " + _user.SALARY + ", null, 2, " + type;   //default lecturer values
                    db.AddToTable(db.TEMPLOYEE, values);
                    db.AddToTable(db.TRECEPTION, id + ", '1', '2015-05-26 00:00:00.000', '2015-05-26 00:00:00.000'");
                    break;

                case 4: //department head 
                    _user = new HeadDept();
                    values = id + ", " + _user.SALARY + ", null, 2, " + type;   //default head dept values
                    db.AddToTable(db.TEMPLOYEE, values);
                    break;
            }

            return db.checkExistance(db.TPERSON, "id = " + id);
        }

    }
}

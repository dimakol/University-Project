using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    static class Finance
    {
        public static float Salary(Job jb)
        {
            float Salary = 0;
            switch ((int)jb)
            {//Calculate(Days per week, Hours per day, Money per hour); 
                case 1: //secretary
                    Salary = Calculate(5, 7.5, 40.37);
                    break;

                case 2: //tutor
                    Salary = Calculate(3, 6, 55.68);
                    break;

                case 3: //lecturer
                    Salary = Calculate(3, 6, 180.27);
                    break;

                case 4: //department head 
                    Salary = Calculate(5, 4.5, 250.13);
                    break;
            }
            return Salary;
        }

        private static float Calculate(int Days, double Hours, double perHour)
        {
            return (float)(perHour * Hours * Days * 4);
        }
    }
}

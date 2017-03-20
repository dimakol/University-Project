using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Secretary : Employee
    {
        public Secretary()
        {
            MyJob();
            MySalary();
        }

        public override void MySalary()
        {
            SALARY = Finance.Salary(this.JOB); ;
        }

        public override void MyJob()
        {
            JOB = Job.Sec;
        }
    }
}

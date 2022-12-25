using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2._0
{
    public class  EmployeeWage
    {
        public void  chekingattendance()
        {
            int IS_FULL_TIME = 1;
            Random random= new Random();
            int empcheck = random.Next(0,2);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
            }
            else 
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
         

    }
}

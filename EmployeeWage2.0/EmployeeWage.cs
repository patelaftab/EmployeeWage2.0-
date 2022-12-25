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
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random= new Random();
            int empcheck = random.Next(0,3);
            if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee Is Present");
            }
            else if(empcheck==IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("EMployee is Part Time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee Is Absent");
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Daily Wage is : " + empWage);
        }
         

    }
}

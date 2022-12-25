using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2._0
{
    public class  EmployeeWage
    {
        public static int  chekingattendance()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            int NUM_OF_WORKING_DAYS = 20;
            int MAX_HRS_IN_MONTH = 100;
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs<= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case 1:
                    IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("Employee Is Present");
                        break;
                    case 2:
                    IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("Employee is Part Time");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee Is Absent");
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "Emp HRS : " +empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage For 20 Days Of Month is :" + totalEmpWage);
            return totalEmpWage;
        }
    }
}

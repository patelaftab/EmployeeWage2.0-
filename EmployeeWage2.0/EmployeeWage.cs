using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2._0
{
    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) //20
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;      //variables
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays) //computation .
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:#" + totalWorkingDays + " Emp Hrs" + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is " + totalEmpWage);
        }
        public override string ToString()
        {
            return "Total Emp Wage for company : " + company + " is " + totalEmpWage;
        }
    }
    //public class EmployeeWage
    //{
    //public const int IS_FULL_TIME = 1;
    //public const int IS_PART_TIME = 2;
    //public static int computeempwage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    //{
    //    int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;      //variables
    //    while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)       //computation
    //    {
    //        totalWorkingDays++;
    //        Random random = new Random();
    //        int empCheck = random.Next(3);
    //        switch (empCheck)
    //        {
    //            case IS_PART_TIME:
    //                empHrs = 4;
    //                break;
    //            case IS_FULL_TIME:
    //                empHrs = 8;
    //                break;
    //            default:
    //                empHrs = 0;
    //                break;
    //        }
    //        totalEmpHrs += empHrs;//as the no of working days will be passing the total no of working hrs will going on added of each day accordingly .
    //        if (totalEmpHrs > maxHoursPerMonth)  //totalEmpHrs should not go beyond defined MaxHrs .
    //        {
    //            totalEmpHrs = maxHoursPerMonth;
    //        }
    //        //Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
    //    }
    //    int totalEmpWage = totalEmpHrs * empRatePerHour;//per hour rate * total working hour to find wage .
    //    Console.WriteLine($"Total Emp Wage for the Company \"{company}\" is : {totalEmpWage}");
    //    return totalEmpWage;
}
    //}
//}

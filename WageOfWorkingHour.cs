using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public static class WageOfWorkingHour
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HR_IN_MONTH = 100;
        public static void WageOfTotalWorkingHr()
        {
            int empHr = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;

            while (totalEmpHr <= MAX_HR_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;

                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                totalEmpHr += empHr;
                Console.WriteLine("Days: " + totalEmpHr);
            }
            int totalEmpWage = totalEmpHr * WAGE_PER_HOUR;
            Console.WriteLine("Total Emp Wage:  " + totalEmpWage);
        }
    }
}

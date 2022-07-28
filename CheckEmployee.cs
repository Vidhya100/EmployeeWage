using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    /// <summary>
    /// Class define employee check
    /// </summary>
    public static class CheckEmployee
    {
        /// <summary>
        /// Checks the employee attendence.
        /// </summary>
        public static void CheckEmployeeAttendence()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int WAGE_PER_HOUR = 20;
            //Variables
            int empHr = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHr = 8;
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
                empHr = 0;
            }
             empWage = empHr * WAGE_PER_HOUR;
            Console.WriteLine("Employee wage is: " + empWage);
        }
    }
}

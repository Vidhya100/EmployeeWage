﻿using System;
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
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int WAGE_PER_HOUR = 20;
            int NUM_OF_WORKING_DAYS = 20;
            //Variables
            int empHr = 0;
            int empWage = 0;
            int totalEmpWage = 0;

                    Random random = new Random();
                    int empCheck = random.Next(3);

                switch(empCheck)
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
                empWage = empHr * WAGE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee wage is: " + empWage);
           
        }
    }
}

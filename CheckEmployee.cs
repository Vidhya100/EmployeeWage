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
            int IS_FULL_TIME = 1;

            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}

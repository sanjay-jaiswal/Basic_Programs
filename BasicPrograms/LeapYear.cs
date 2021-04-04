using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LeapYear
    {
        public static void leapYear()
        {
            Console.WriteLine("Please enter the year : ");
            int checkLeapYear = Convert.ToInt32(Console.ReadLine());
            if (checkLeapYear % 400 == 0 || (checkLeapYear % 4 == 0 && checkLeapYear % 100 != 0))
            {
                Console.WriteLine("Leap year!!");
            }
            else
            {
                Console.WriteLine("Not a leap year!!");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    public class PowerOfTwo
    {
        public static void calculatePowerOfNum()
        {
            Console.WriteLine("Please enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            double powerOfNum = Math.Pow(number, 2);
            Console.WriteLine("The power of number is : " + powerOfNum);
            Console.ReadLine();
        } 
    }
}
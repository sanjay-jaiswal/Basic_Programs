using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram2
{
   public class WindChill
    {
        public static void calTemp()
        {
                int t =50, v=120;
                double temp;
                Console.WriteLine("---Welcome to Wind Chill Program---");
                Console.WriteLine("Please enter temperature in the range of -0 and 50 dF: ");
                temp = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter wind speed range in between 3MPH to 120MPH ");
                double speedOfWind = Convert.ToDouble(Console.ReadLine());
            if (t < 50 && v < 120)
            {
                double windchilling = 35.74 + 0.6215 * temp
                        - 35.75 * Math.Pow(speedOfWind, 0.16)
                        + 0.4275 * temp * Math.Pow(speedOfWind, 0.16);

                Console.WriteLine("Wind chill is  : " + windchilling);
            }
            else
                Console.WriteLine("Invalid input");

        }
    }
}

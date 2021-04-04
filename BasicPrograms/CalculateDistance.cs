using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
   public  class CalculateDistance
    {
       public  void distanceCalculate()
        {
            Console.WriteLine("---Welcome To Cartesian distance calculation Program---");
            //Variable declaration
            double x1, y1, x2, y2;
            //For line 2
            Console.WriteLine("Enter the cordinates (x1,y1) :");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cordinates (x2,y2) :");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
          
            //Calculate line 1 and line 2 distance
            double dis = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Distance betweentwo points is : "+dis);
        }
    }
}

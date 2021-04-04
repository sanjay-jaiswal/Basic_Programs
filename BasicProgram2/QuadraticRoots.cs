using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram2
{
   public class QuadraticRoots
    {
        public static void findRoots()
        {
            double a, b, c;
            double disc, deno, x1, x2;
            Console.WriteLine("ENTER THE VALUES OF A,B,C...");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("The roots are Linear:", x1);
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
                    x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    Console.WriteLine("THE ROOTS ARE : " + x1 + " and " + x2);
                }
                else if (disc == 0)
                {
                    Console.WriteLine("THE ROOTS ARE REPEATED ROOTS");
                    x1 = -b / deno;
                    Console.WriteLine("THE ROOT IS...: " + x1);
                }
                else
                {
                    Console.WriteLine("THE ROOTS ARE IMAGINARY ROOTS\n");
                    x1 = -b / deno;
                    //calculate imaginary roo. And here -i/+i indicates that root are imaginary.
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    Console.WriteLine("THE ROOT 1: " + x1 + "+i" + x2);
                    Console.WriteLine("THE ROOT 2:" + x1 + "-i" + x2);
                }
            }
            Console.ReadLine();
        }
    }
}
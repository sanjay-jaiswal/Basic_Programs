using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram2
{
    public class FindQuadraticRoots
    {
        public static void findQuadRoots()
        {
            int a, b, c;
            double discriminant, denomenator, X1, X2;
            Console.WriteLine("---Welcome to Quadratic Equation to find roots---");
            Console.WriteLine("The quadratic equation is like ax^2 + bx + c = 0 . just enter the value of a,b and c. ");

            Console.WriteLine("Please enter the value of a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of c :");
            c = Convert.ToInt32(Console.ReadLine());

            discriminant = b * b - 4 * a * c;
            denomenator = 2 * a;

            // if discriminant is zero then equation is not quadratic but linear.
            if (a == 0)
            {
                Console.WriteLine("Not Possible!!");
            }

            else
            {
                //id disc is greater than zero then roots are real and distinct
                if (discriminant > 0)
                {
                    Console.WriteLine("Both roots are real and different : ");
                    X1 = (-b / denomenator) + (Math.Sqrt(discriminant) / denomenator);
                    X2 = (-b / denomenator) - (Math.Sqrt(discriminant) / denomenator);
                    Console.WriteLine("Roots are : " + X1 + " and " + X2);

                }
                else if (discriminant == 0)
                {
                    Console.WriteLine("Both roots are repeated...or Same.");
                    X1 = -b / denomenator;
                    Console.WriteLine("Root is : " + X1);
                }
                else
                {
                    Console.WriteLine("Both roots are imaginary\n");
                    X1 = -b / denomenator;
                    X2 = ((Math.Sqrt((4 * a * c) - (b * b))) / denomenator);
                    Console.WriteLine("1st root is : " + X1 + "+i" + X2);
                    Console.WriteLine("2nd root is :" + X1 + "-i" + X2);
                }
            }
            Console.ReadLine();
        }
    }
}
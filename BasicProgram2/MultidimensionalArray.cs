using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram2
{
    public class MultidimensionalArray
    {
        public static void ReadMultiArray()
        {
            Object[][] array = new object[4][];
            array[0] = new object[4];
            array[1] = new object[4];
            array[2] = new object[4];
            array[3] = new object[4];

            Console.WriteLine("Enter integer array of f4 elements : ");
            for(int i=0;i<4;i++)
            {
                array[0][i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter boolean array of f4 elements : ");
            for (int i = 0; i < 4; i++)
            {
                array[1][i] = Convert.ToBoolean(Console.ReadLine());
            }

            Console.WriteLine("Enter string array of f4 elements : ");
            for (int i = 0; i < 4; i++)
            {
                array[2][i] = Console.ReadLine();
            }

            Console.WriteLine("Enter double array of f4 elements : ");
            for (int i = 0; i < 4; i++)
            {
                array[3][i] = Convert.ToDouble(Console.ReadLine());
            }

            //iterating for each array object of size 4.
            for (int i=0; i<4; i++)
            {
                for(int j =0; j<array[i].Length; j++)
                {
                    Console.WriteLine(array[i][j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}

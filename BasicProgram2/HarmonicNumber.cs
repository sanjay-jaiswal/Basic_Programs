using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram2
{
    class HarmonicNumber
    {

        public static void ReadHarmonicNumber()
        {
            Console.WriteLine("Please enter nth harmonic number");
            int nthNumber = Convert.ToInt32(Console.ReadLine());
            Harmonic(nthNumber);
            //Console.WriteLine("sum of all harmonic list "+result);
        }

        private static void Harmonic(int lastNumber)
        {
            double sum = 0;
            // 1/1 + 1/2 + 1/3 ..... +1/5 (or sum value)
            for (int i = 1; i <= lastNumber; i++)
            {
                Console.Write("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            //Console.WriteLine(sum + "+");
            Console.Write("\nSum of Series upto {0} terms : {1} \n", lastNumber, sum);

        }
    }
}


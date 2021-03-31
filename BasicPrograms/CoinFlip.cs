using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class CoinFlip
    {
        //Input method to take i/p from user
        public void ReadInput()
        {
            Console.WriteLine("How many number of times you wants to flip the coin : ");
            string input = Console.ReadLine();
            //converting from string to int.
            int numOfTimes = Convert.ToInt32(input);
            //Flip() method calling
            Flip(numOfTimes);
        }

        private static void Flip(int numOfTimes)
        {
            // Variables initialization
            int tail = 0; int head = 0;
            Random random = new Random();
            for (int i = 1; i <= numOfTimes; i++)
            {
                //random.next will get random values from 0 to 1
                if (random.NextDouble() < 0.5)
                {
                    //tail increment by 1
                    tail++;
                }
                else
                    // head increment by 1
                    head++;
            }
            //Percentage calculation
            double tailPercentage = (double)tail / numOfTimes * 100;
            double headPercentage = (double)head / numOfTimes * 100;

            //Prints no of count and percentage for both.
            Console.WriteLine("Tail count" + "=" + tail + "\tPercentage " + tailPercentage);
            Console.WriteLine("Head count" + "=" + head + "\tPercentage " + headPercentage);
        }
    }
}

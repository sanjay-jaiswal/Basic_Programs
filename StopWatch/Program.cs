using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();

            while (true)
            {
                Console.WriteLine("Please enter your input : ");

                Console.WriteLine("1.start | 2.stop | 3.quit");

                var inputNum = Convert.ToInt32(Console.ReadLine());

                if (inputNum == 1)
                {
                    stopWatch.Start();
                }
                else if (inputNum == 2)
                {
                    stopWatch.Stop();
                    stopWatch.Calculate();

                }
                else if (inputNum == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    throw new InvalidOperationException("Invalid input");
                }

            }
            }
        }
}

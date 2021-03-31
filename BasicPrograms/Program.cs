using System;

namespace BasicPrograms
{
    class Program
    {
        /// <summary>
        /// Execution starts from main() metod
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StringReplacing replace = new StringReplacing();
            replace.ReadInput();

            //Creating object of coinflip method to call non-static method.
            CoinFlip flip = new CoinFlip();
            flip.ReadInput();
            Console.Read();

            //LeapYear lp = new LeapYear();
            
        }
    }
}

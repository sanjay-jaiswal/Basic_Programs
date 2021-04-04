using System;

namespace BasicPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringReplacing replace = new StringReplacing();
            //replace.ReadInput();

            //Creating object of coinflip method to call non-static method.
            // CoinFlip flip = new CoinFlip();
            //flip.ReadInput();
            //Console.Read();

            //LeapYear lp = new LeapYear();
            //PowerOfTwo pw = new PowerOfTwo();
            // pw.calculatePowerOfNum;

            
            
               
               // primeFactors(n);
     

           // PrimeFactorisation.primeFactors(int n);
            //Console.WriteLine();


            Console.WriteLine("1.Coin flip  2.Leap year 3. Power of two  4.String Replacing 5. Distance calculate ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CoinFlip.ReadInput();
                    break;
                case 2:
                    LeapYear.leapYear();
                    break;
                case 3:
                    PowerOfTwo.calculatePowerOfNum();
                    break;
                case 4:
                    StringReplacing sr = new StringReplacing();
                    sr.ReadInput();
                    break;
                case 5:
                    CalculateDistance cd = new CalculateDistance();
                    cd.distanceCalculate();
                    break;
                default:
                    break;

            }
        }
    }
}
    
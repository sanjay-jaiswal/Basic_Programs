using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram2
{
    public class CouponNumber
    {
        public static void ReadNumberOfCoupon()
        {
            Console.WriteLine("Enter a number for distinct coupons");
            int couponNum = Convert.ToInt32(Console.ReadLine());
            FindOutRandomCount(couponNum);

        }

        private static void FindOutRandomCount(int couponNum)
        {
            int distinct = 0, count = 0;
            bool[] isCollected = new bool[couponNum];
            while(distinct<couponNum)
            {
                Random random = new Random();
                int newRandom = Convert.ToInt32(random.Next(0, couponNum));
                count++;
                if(!isCollected[newRandom])
                {
                    distinct++;
                    isCollected[newRandom] = true;
                }
            }
            Console.WriteLine("Total random number needed to have all distinct count" +count);
        }
    }
}

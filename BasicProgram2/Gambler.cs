using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram2
{
    class Gambler
    {
        public static void ReadStackAmountAndGoal()
        {
            int wons = 0;
            int loose = 0;
            Console.WriteLine("Enter stack amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter goal amount");
            int goal = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();            
            for(int i=1; i>0; i++)
            {
                if (amount > 0)
                {
                    int randomValue = random.Next(0, 2);

                    if (randomValue == 1)
                    {
                        amount = amount + 1;
                        wons++;

                        if(amount == goal)
                        {
                            Console.WriteLine("Number of bets played in game" + i);
                            Console.WriteLine("Number of wons"+wons);
                            Console.WriteLine("Number of loose" + loose);
                            break;
                        }
                    }
                    else
                    {
                        if(amount>0)
                        {
                            amount = amount - 1;
                            loose++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Game broken that means amount is not sifficient");
                    break;
                }
            }
            Console.WriteLine("Final amount either it may reaches the goal or break the game" + amount);
        }
    }
}

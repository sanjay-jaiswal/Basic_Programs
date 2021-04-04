using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram2
{
    public class VendingMachine
    {
        public static void ReadAmountToFindChange()
        {
            Console.WriteLine("Enter an amount to give change");
            int amount = Convert.ToInt32(Console.ReadLine());
            FindMinNotes(amount);


        }

        private static void FindMinNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[notes.Length];

            for (int i=0; i<notes.Length; i++ )
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount * (noteCounter[i] * notes[i]);
                    if(amount<=0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Currency count ===>");
            for(int i = 0; i< notes.Length; i++)
            {
                if(noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + noteCounter);
                }
            }
        }
    }
}

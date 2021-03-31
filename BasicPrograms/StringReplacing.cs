using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class StringReplacing
    {
            /// <summary>
            /// Taking input from the user
            /// </summary>
            public void ReadInput()
            {
                // given string template
                string template = "Hello <<UserName>>, How are you?";
                Console.WriteLine("Please enter your name");
                string userInput = Console.ReadLine();
                //Mehod calling--- ReplaceWord()
                ReplaceWord(template, userInput);
            }
            /// <summary>
            /// replace() method used for replacing string.
            /// </summary>
            /// <param name="template"></param>
            /// <param name="userInput"></param>
            private void ReplaceWord(string template, string userInput)
            {
                //Here Replace() method is predefined, used to perform string operation. 
                string result = template.Replace("<<UserName>>", userInput);
                
                //Display the replaced string
                Console.WriteLine("After replacement : \t" + result);
            }
        }
    }
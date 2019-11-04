using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Globalization;

namespace mid_exam
{

    class Program
    {
        static void Main()
        {

            char[] input = Console.ReadLine().ToArray();
            string nums = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (Char.IsDigit(currentChar))
                {
                    nums += currentChar;
                    continue;
                }
                if (char.IsLetter(currentChar))
                {
                    letters += currentChar;
                    continue;

                }
                else
                {
                    others += currentChar;
                }
            }
            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
        
     }
}


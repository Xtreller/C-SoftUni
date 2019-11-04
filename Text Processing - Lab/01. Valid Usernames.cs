using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace mid_exam
{

    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(", ");

            for (int i = 0; i < words.Length; i++)
            {
                bool isValid = false;
                if (words[i].Length >= 3 && words[i].Length <= 16)
                {
                    for (int p = 0; p < words[i].Length; p++)
                    {
                        char currentChar = words[i][p];
                        if (char.IsLetterOrDigit(words[i][p])||words[i][p]=='-'|| words[i][p] == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

    }
}


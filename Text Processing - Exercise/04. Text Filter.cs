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
            List<string> bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string text = Console.ReadLine();
            
            for (int i = 0; i < bannedWords.Count; i++)
            {
                while (text.Contains(bannedWords[i]))
                {
                    string replacer = new string('*', bannedWords[i].Length);
                    text = text.Replace(bannedWords[i], replacer);
                }
            }
            Console.WriteLine(text);
        }
        
     }
}


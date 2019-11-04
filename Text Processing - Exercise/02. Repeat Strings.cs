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
            string[] words = Console.ReadLine().Split();
            string result = string.Empty;
            foreach (var word in words)
            {
                int lenght = word.Length;
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }

            }
            Console.WriteLine(result);


        }
    }
}

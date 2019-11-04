using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace mid_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var pos2 = rnd.Next(words.Length);
                string firstWord = words[i];
                words[i] = words[pos2];
                words[pos2] = firstWord;

            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace mid_exam
{

    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split('\\').ToList();

            string[] split = input.Last().Split('.');
            Console.WriteLine($"File name: {split[0]}");
            Console.WriteLine($"File extension: {split[1]}");
            
                
        }

    }
}


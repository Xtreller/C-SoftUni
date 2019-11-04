using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace mid_exam
{

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (var item in input)
            {
                char encSymbol = (char)(item + 3);
                sb.Append(encSymbol);
            }
            Console.WriteLine(sb);
        }

    }
}


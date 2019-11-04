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
            for (int i = 0; i < input.Length; i++)
            {
                
                if (i == input.Length - 1)
                {
                    sb.Append(input.Last());
                    break;
                }
                if (input[i+1]!=input[i])
                {
                    sb.Append(input[i]);
                }
                
            }
            Console.WriteLine(sb);
        }

    }
}


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
            while (true)
            {
                string result = string.Empty;
                string word = Console.ReadLine();
                if (word=="end")
                {
                    break;
                }
                for (int i = word.Length-1; i >= 0; i--)
                {
                    result += word[i];
                }
                Console.WriteLine(word +" = "+result);
            }



        }
    }
}

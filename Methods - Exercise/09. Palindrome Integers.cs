using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PalindromNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();
                if (word=="END")
                {
                    break;
                }
                if (IsSymmetrical(word)==true)
                {
                    Console.WriteLine("true");
                }
                if (IsSymmetrical(word)==false)
                {
                    Console.WriteLine("false");
                }
                
            }
        }
        private static bool IsSymmetrical(string word)
        {
            string num = word;
            int min = 0;
            int max = num.Length - 1;
            while (min < max)
            {
                if (char.ToLower(num[min]) != char.ToLower(num[max]))
                {
                    return false;
                }
                min++;
                max--;
            }
            return true;
        }
    }
}

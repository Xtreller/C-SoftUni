using System;
using System.Text;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            if (str.Length % 2 == 0)
            {
                Console.WriteLine(getMiddleOfEvenString(str));
            }
            else
            {
                Console.WriteLine(getMiddleOfOddString(str));
            }
        }
        static string getMiddleOfEvenString(string str)
        {
            string res = string.Empty;
            for (int i = (str.Length / 2) - 1; i <= (str.Length / 2); i++)
            {
                res += str[i];
            }
            return res;
        }
        static char getMiddleOfOddString(string str)
        {
            return str[str.Length / 2];
        }
    }
}
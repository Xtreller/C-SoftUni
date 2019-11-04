using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            repeatString(str, count);
        }
        private static string repeatString(string lett, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += lett;
            }
            Console.WriteLine(result);
            return result;

        }

    }
}
using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            int end = int.Parse(Console.ReadLine());
            for (int i = 0; i <= end; i++)
            {
                PrintLine(1,i);
            }
            for (int p = end-1; p >=1; p--)
            {
                PrintLine(1,p);
            }

        }
        public static void PrintLine(int start ,int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write( i + " ");
            }
            Console.WriteLine();
            return;
        }
    }
}
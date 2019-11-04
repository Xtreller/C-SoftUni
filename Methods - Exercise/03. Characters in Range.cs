using System;
using System.Text;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            char start = char.Parse (Console.ReadLine());
            char end = char.Parse (Console.ReadLine());
            Console.WriteLine(getcharsBtwChars(start, end));

        }
        public static string getcharsBtwChars(char start,char end)
        {            
                for (int i = getMin(start,end) + 1; i < getMax(start,end); i++)
                {
                    Console.Write((char)i + $" ");

                }
                   
            string result = string.Empty;

            return result;
        }
        static char getMax(char firstChar, char secondChar)
        {
            return (char)Math.Max(firstChar, secondChar);

        }
        static char getMin(char firstChar, char secondChar)
        {
            return (char)Math.Min(firstChar, secondChar);

        }
    }
}
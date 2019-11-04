using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            string dataType = Console.ReadLine();
            switch (dataType)
            {
                case "int":
                    int n = int.Parse(Console.ReadLine());
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine(getMax(n, k));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(getMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(getMax(secondString, firstString));
                    break;
                default:
                    break;
            }

        }
        static char getMax(char firstChar,char secondChar)
        {
            return (char)Math.Max(firstChar, secondChar);
            
        }
        static int getMax(int firstInt, int secondInt)
        {            
            return Math.Max(firstInt,secondInt);
        }
        static string getMax(string firstString,string secondString)
        {
            int max = int.MinValue;
            double greaterString = firstString.CompareTo(secondString);
            if (greaterString>0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }

        }
    }
}
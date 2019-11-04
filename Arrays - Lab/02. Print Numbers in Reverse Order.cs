using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
            int number = int.Parse(Console.ReadLine());
                numbers[i] = number;

            }
            for (int i = numbers.Length-1; i>=0 ; i--)
            {
                Console.Write(numbers[i] + $" ");
            }
        }
        
    }
}

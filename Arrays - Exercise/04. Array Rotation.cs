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
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int countOfRotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfRotations; i++)
            {
                int firsElement = 0;
                firsElement = numbers[0];
                for (int p = 0; p < numbers.Length-1; p++)
                {
                    numbers[p] = numbers[p + 1];
                }
                numbers[numbers.Length - 1] = firsElement;


            }
            Console.WriteLine(string.Join(" ",numbers));
        }
            
    }
}

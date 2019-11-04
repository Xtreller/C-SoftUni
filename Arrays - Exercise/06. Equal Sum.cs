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
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int leftSuming = 0; leftSuming < i; leftSuming++)
                {
                    leftSum += numbers[leftSuming];
                }
                for (int rightSuming = i+1; rightSuming < numbers.Length ; rightSuming++)
                {
                    rightSum += numbers[rightSuming];
                }
                if (rightSum==leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                if (numbers.Length==1)
                {
                    Console.WriteLine("0");
                }
                

            }
            Console.WriteLine("no");
        }

    }
}

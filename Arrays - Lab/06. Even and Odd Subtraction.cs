using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evens = 0;
            int odds = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentNumb = number[i];
                if (currentNumb%2==0)
                {
                    evens += number[i];   
                }
                else
                {
                    odds += number[i];
                }
            }
            Console.WriteLine(evens-odds);
        }
    }
}

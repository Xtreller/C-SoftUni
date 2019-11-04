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
            int lenght = int.Parse(Console.ReadLine());

            int[] firstArr = new int[lenght];
            int[] secondArr = new int[lenght];



            for (int i = 0; i < lenght; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                int firstNumb = int.Parse(tokens[0]);
                int secondNumb = int.Parse(tokens[1]);
                if (i%2==0)
                {
                    firstArr[i] = firstNumb;
                    secondArr[i] = secondNumb;
                }
                else
                {
                    firstArr[i] = secondNumb;
                    secondArr[i] = firstNumb;
                }


            }
            Console.WriteLine(string.Join(" ",firstArr));
            Console.WriteLine(string.Join(" ",secondArr));
        }
            
    }
}

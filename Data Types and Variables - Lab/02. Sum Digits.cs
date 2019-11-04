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
            int num = int.Parse(Console.ReadLine());
            int temp = 0;
            int sum = 0;

            temp = num;
            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}

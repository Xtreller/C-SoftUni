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
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());

            if (n<=7 && n >0)
            {
                n--;

                Console.WriteLine(days[n]);

            }
            else 
            {
                Console.WriteLine("Invalid day!");
            }

        }
        
    }
}

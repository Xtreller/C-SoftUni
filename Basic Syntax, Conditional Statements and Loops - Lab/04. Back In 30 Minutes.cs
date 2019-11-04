using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            minutes += 30;
            if (minutes>59)
            {
                hours++;
                minutes -= 60;
                if (hours>23)
                {
                    hours = 0;

                }
            }
            if (minutes<10)
            {
                Console.WriteLine($"{hours}:0{minutes}");

            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");

            }
        }
    }
}
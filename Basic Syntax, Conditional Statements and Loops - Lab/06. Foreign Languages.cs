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
            string month = Console.ReadLine();
            if (month=="USA" || month== "England")
            {
                Console.WriteLine("English");
            }
           else if (month == "Spain"|| month=="Argentina" || month=="Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}





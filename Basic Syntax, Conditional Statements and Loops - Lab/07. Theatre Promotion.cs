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
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            if (day == "Weekday")
            {
                if (age <= 18 && age >= 0)
                {
                    price = 12;
                    Console.WriteLine(price + "$");

                }
                if (age > 18 && age <= 64)
                {
                    price = 18;
                    Console.WriteLine(price + "$");

                }
                if (age > 64 && age <= 122)
                {
                    price = 12;
                    Console.WriteLine(price + "$");

                }
                if (age < 0 && age > 122)
                {
                    Console.WriteLine("Error!");

                }

            }
            else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                    Console.WriteLine(price + "$");

                }
                if (age > 18 && age <= 64)
                {
                    price = 20;
                    Console.WriteLine(price + "$");

                }
                if (age > 64 && age <= 122)
                {
                    price = 15;
                    Console.WriteLine(price + "$");

                }
                if(age<0 && age >122)
                {
                    Console.WriteLine("Error!");

                }

            }
            else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                    Console.WriteLine(price + "$");

                }
               else if (age > 18 && age <= 64)
                {
                    price = 12;
                    Console.WriteLine(price + "$");

                }
              else  if (age > 64 && age <= 122)
                {
                    price = 10;
                    Console.WriteLine(price + "$");

                }
               else if (age < 0 && age > 122)
                {
                    Console.WriteLine("Error!");

                }

            }
        }
    }
}
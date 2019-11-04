using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());

        
         if (age % 10 == 0 )
        {
            Console.WriteLine("The number is divisible by 10");
        }
        else if (age % 7 == 0)
        {
            Console.WriteLine("The number is divisible by 7");
        }
        else if (age % 6 == 0 || (age % 2 == 0 && age % 3 == 0))
        {
            Console.WriteLine("The number is divisible by 6");
        }
        else if (age % 3 == 0 && age%2!=0)
        {
            Console.WriteLine("The number is divisible by 3");
        }
        else if (age % 2 == 0 && age % 3 != 0)
        {
            Console.WriteLine("The number is divisible by 2");
        }
        else
        {
            Console.WriteLine("Not divisible");
        }

    }
}
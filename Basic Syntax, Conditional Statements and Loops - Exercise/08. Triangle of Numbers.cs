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
        int Numb = int.Parse(Console.ReadLine());;

        for (int i = 0; i <= Numb; i++)
        {
            for (int p = 1; p <= i; p++)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();

        }

    }
}
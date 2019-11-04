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
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
            Console.Write(i+" ");
        }
        Console.WriteLine();
        Console.WriteLine($"Sum: {sum}");
    }
}
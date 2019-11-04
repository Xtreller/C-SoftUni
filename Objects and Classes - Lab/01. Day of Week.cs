using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace mid_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime Time = DateTime.ParseExact(date,"d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(Time.DayOfWeek);
        }
    }
}

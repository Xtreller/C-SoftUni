using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace mid_exam
{

    class Program
    {
        static void Main()
        {
            string num1 = Console.ReadLine().TrimStart(new char[] { '0' });
            int numb2 = int.Parse(Console.ReadLine());
            if (numb2==0)
            {
                Console.WriteLine(0);
                return;
            }
            int decimalReminder = 0;
            int currentCalc  = 0;
            List<int> result = new List<int>();
            for (int i = num1.Length-1; i >=0; i--)
            {
                int currentDigit = num1[i] - '0' ;
                currentCalc = currentDigit * numb2;
                currentCalc += decimalReminder;
                result.Add(currentCalc % 10);
                decimalReminder = currentCalc / 10;
            }
            if (decimalReminder>0)
            {
                result.Add(decimalReminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("",result));
        }

    }
}


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
        int checkNumb = Numb;
        int factoriel = 1;
        int sum = 0;
        

        while (checkNumb!=0)
        {
            int lastnumb = checkNumb % 10;
            checkNumb /= 10;

            for (int i = 1; i <=lastnumb; i++)
            {
                factoriel *= i;
            }
            sum += factoriel;
            factoriel = 1;
           
        }
        if (sum == Numb)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}
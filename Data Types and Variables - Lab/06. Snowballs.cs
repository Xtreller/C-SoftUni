using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSnowballs = int.Parse(Console.ReadLine());
            double snowballValue = 0;
            int snowballsnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;

            for (int i = 0; i < countOfSnowballs; i++)
            {
                int currentSnowballSnow = int.Parse(Console.ReadLine());
                int currentSnowballTime= int.Parse(Console.ReadLine());
                int currentSnowballQuality = int.Parse(Console.ReadLine());
                double currentsnowballValue =Math.Pow((currentSnowballSnow / currentSnowballTime),currentSnowballQuality);
                Math.Round(currentsnowballValue);
                if (currentsnowballValue>snowballValue)
                {
                    snowballValue = currentsnowballValue;

                    snowballsnow = currentSnowballSnow;
                    snowballTime = currentSnowballTime;
                    snowballQuality = currentSnowballQuality;

                }                
            }
            Console.WriteLine($"{snowballsnow} : {snowballTime} = {snowballValue} ({snowballQuality})");

        }
    }
}

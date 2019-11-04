using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Globalization;

namespace mid_exam
{

    class Program
    {
        static void Main()
        {
            string ice = Console.ReadLine();
            string word = Console.ReadLine();
            ice = ice.ToLower();


            while (word.Contains(ice))
            {


                int indexofIce = word.IndexOf(ice);
                word = word.Remove(indexofIce, ice.Length);
                
            }
            Console.WriteLine(word);
        }
    }
}

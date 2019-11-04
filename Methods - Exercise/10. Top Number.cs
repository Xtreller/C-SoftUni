using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 8; i < n; i++)
            {
                int num = i;
                if (CheckForOdds(i) && CheckIsDivisableBy8(i))
                {
                    Console.WriteLine(i);
                }
                
            }




        }
        public static bool CheckForOdds(int n)
        {

            while (n != 0)
            {
                var last = n % 10;
                n /= 10;

                if (last % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckIsDivisableBy8(int n)
        {
            int sum = 0;
            while (n!=0)
            {
                int last = n % 10;
                n /= 10;
                sum += last;

            }
            if (sum%8==0)
            {
                return true;
            }
            return false;
        }
      
    }
}
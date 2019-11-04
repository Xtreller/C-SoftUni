using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(smallestNumb(first,second,third));
        
        }
        public static int smallestNumb(int first,int second ,int third)
        {
            int min = int.MaxValue;
            if (first<min)
            {
                min = first;
            }
            if (second<min)
            {
                min = second;
            }
            if(third<min)
            {
                min = third;
            }
            return min;
        }
        
       
        
    }
}
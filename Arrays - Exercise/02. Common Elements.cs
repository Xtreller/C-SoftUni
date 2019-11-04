using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                 .Split()
                 .ToArray();

            string[] secondArr = Console.ReadLine()
                 .Split()
                 .ToArray();
            
            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int p = 0; p < firstArr.Length; p++)
                {

                    if (firstArr[p] == secondArr[i])
                    {
                        Console.Write(secondArr[i]+ " ");
                    }    
                }
            }
        }

    }
}

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
            string[] words = Console.ReadLine().Split();
            
            var dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string lowered = word.ToLower();
                if (!dict.ContainsKey(lowered))
                {
                    dict.Add(lowered,1);

                }
                dict[lowered]++;
                
            }

            foreach (var count in dict)
            {
                if (count.Value%2==0)
                {
                    Console.Write(count.Key + " ");
                }
            }
           

        }


    }
}

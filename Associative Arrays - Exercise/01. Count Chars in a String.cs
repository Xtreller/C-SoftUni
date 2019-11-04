using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_exam
{

    class Program
    {
        static void Main()
        {
            string[] charSequence = Console.ReadLine().Split();
            var dict = new Dictionary<char, int>();
            foreach (var item in charSequence)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    char currentChar = item[i];
                    if (dict.ContainsKey(currentChar))
                    {
                        dict[currentChar]++;
                    }
                    else
                    {
                        dict.Add(currentChar, 1);
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }

    }

}


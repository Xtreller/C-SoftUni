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
            var dict = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else
                {
                    int value = int.Parse(Console.ReadLine());
                    if (dict.ContainsKey(input))
                    {
                        dict[input] += value;
                    }
                    else
                    {
                        dict.Add(input, value);
                    }
                }

            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> "+item.Value );
            }
        }

    }

}


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

            var dict = new Dictionary<string, double[]>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                var innerDict = new Dictionary<double, int>();

                string[] token = input.Split();
                string product = token[0];
                double price = double.Parse(token[1]);
                int quantity = int.Parse(token[2]);
                if (!dict.ContainsKey(product))
                {
                    dict.Add(product, new double[2]);
                }
                dict[product][0] = price;
                dict[product][1] += quantity;
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> " + $"{item.Value[0]*item.Value[1]:f2}");
            }
        }
    }

}


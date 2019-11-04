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
            int n = int.Parse(Console.ReadLine());
            
            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word,new List<string>());

                }                
                dict[word].Add(synonyms);
            }
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ",kvp.Value)}");
            }

        }


    }
}

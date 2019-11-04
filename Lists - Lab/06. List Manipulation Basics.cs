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
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {


                string commandOrEnd = Console.ReadLine();

                if (commandOrEnd == "end")
                {
                    break;
                }
                string[] tokens = commandOrEnd.Split();
                int numb = int.Parse(tokens[1]);
                if (tokens[0] == "Add")
                {
                    firstList.Add(numb);
                }
                else if (tokens[0] == "Remove")
                {
                    firstList.Remove(numb);
                }
                else if (tokens[0] == "RemoveAt")
                {
                    firstList.RemoveAt(numb);

                }
                else if (tokens[0] == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    firstList.Insert(index, numb);

                }


            }
            Console.WriteLine(string.Join(" ", firstList));

        }
    }
}

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
            bool ToPrint = false;
            while (true)
            {


                string commandOrEnd = Console.ReadLine();

                if (commandOrEnd == "end")
                {
                    break;
                }
                string[] tokens = commandOrEnd.Split();
                if (tokens[0] == "Contains")
                {
                    int numb = int.Parse(tokens[1]);

                    if (firstList.Contains(numb) == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (tokens[0] == "PrintEven")
                {
                    List<int> evens = new List<int>();
                    for (int i = 0; i < firstList.Count; i++)
                    {
                        if (firstList[i] % 2 == 0)
                        {
                            evens.Add(firstList[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", evens));

                }
                else if (tokens[0] == "PrintOdd")
                {
                    List<int> Odds = new List<int>();
                    for (int i = 0; i < firstList.Count; i++)
                    {
                        if (firstList[i] % 2 == 1)
                        {
                            Odds.Add(firstList[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", Odds));
                }
                else if (tokens[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < firstList.Count; i++)
                    {
                        sum += firstList[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (tokens[0] == "Add")
                {
                    int numb = int.Parse(tokens[1]);

                    firstList.Add(numb);
                    ToPrint = true;
                }
                else if (tokens[0] == "Remove")
                {
                    ToPrint = true;

                    int numb = int.Parse(tokens[1]);

                    firstList.Remove(numb);
                }
                else if (tokens[0] == "RemoveAt")
                {
                    ToPrint = true;

                    int numb = int.Parse(tokens[1]);

                    firstList.RemoveAt(numb);

                }
                else if (tokens[0] == "Insert")
                {
                    ToPrint = true;

                    int numb = int.Parse(tokens[1]);

                    int index = int.Parse(tokens[2]);
                    firstList.Insert(index, numb);

                }
                else if (tokens[0] == "Filter")
                {
                    List<int> filtered = new List<int>();
                    int numb = int.Parse(tokens[2]);
                    if (tokens[1] == "<")
                    {
                        for (int i = 0; i < firstList.Count; i++)
                        {
                            if (firstList[i] < numb)
                            {
                                filtered.Add(firstList[i]);
                            }
                        }

                    }
                    if (tokens[1] == ">")
                    {
                        for (int i = 0; i < firstList.Count; i++)
                        {
                            if (firstList[i] >numb)
                            {
                                filtered.Add(firstList[i]);
                            }
                        }
                    }
                    if (tokens[1] == ">=")
                    {
                        for (int i = 0; i < firstList.Count ; i++)
                        {
                            if (firstList[i] >= numb)
                            {
                                filtered.Add(firstList[i]);
                            }
                        }
                    }
                    if (tokens[1] == "<=")
                    {
                        for (int i = 0; i < firstList.Count; i++)
                        {
                            if (firstList[i] <= numb)
                            {
                                filtered.Add(firstList[i]);
                            }
                        }

                    }
                    Console.WriteLine(string.Join(" ", filtered));

                }


            }
            if (ToPrint)
            {
                Console.WriteLine(string.Join(" ", firstList));
            }

        }
    }
}

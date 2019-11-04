using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> Wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand=="end")
                {
                    break;
                }
                string[] tokens = comand.Split();
                
                if (tokens[0]=="Delete")
                {
                    for (int i = 0; i < Wagons.Count; i++)
                    {
                        int number = int.Parse(tokens[1]);
                        if (Wagons[i]==number)
                        {
                            Wagons.Remove(number);
                        }
                    }

                }
                if (tokens[0]=="Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    Wagons.Insert(index, number);
                }

            }
            Console.WriteLine(string.Join(" " , Wagons));
        }

    }
}
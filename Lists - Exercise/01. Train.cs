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
            int WagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;

                }
                string[] tokens = input.Split();
                if (tokens[0] == "Add")
                {
                    int pasengers = int.Parse(tokens[1]);
                    Wagons.Add(pasengers);
                }
                else
                {
                    int PasengersToAdd = int.Parse(tokens[0]);
                    for (int i = 0; i < Wagons.Count; i++)
                    {
                        if (PasengersToAdd+Wagons[i]<=WagonCapacity)
                        {
                            Wagons[i] += PasengersToAdd;
                            break;
                        }
                    }
                }


            }
            Console.WriteLine(string.Join(" ",Wagons));



        }

    }
}
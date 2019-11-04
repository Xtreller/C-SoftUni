using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> guests = new List<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string comand = Console.ReadLine();
                string[] tokens = comand.Split();
                string name = tokens[0];
                if (tokens[2] == "going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }

                }
                if (tokens[2] == "not")
                {

                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }

                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }

    }
}
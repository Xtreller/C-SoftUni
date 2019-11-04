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

            int numbOfComands = int.Parse(Console.ReadLine());
            var registered = new Dictionary<string, string>();
            for (int i = 0; i < numbOfComands; i++)
            {
                string[] comand = Console.ReadLine().Split();
                if (comand[0] == "register")
                {
                    if (!registered.ContainsKey(comand[1]))
                    {
                        registered.Add(comand[1], comand[2]);
                        Console.WriteLine($"{comand[1]} registered {comand[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {comand[2]}");
                    }

                }
                if (comand[0] == "unregister")
                {
                    if (registered.ContainsKey(comand[1]))
                    {
                        registered.Remove(comand[1]);
                        Console.WriteLine($"{comand[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine("ERROR: user Lily not found");

                    }
                }

            }
            foreach (var item in registered)
            {
                Console.WriteLine(item.Key + " => " + item.Value);
            }
        }
    }

}


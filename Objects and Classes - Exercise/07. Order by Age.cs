using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class People
    {
        public string Name{ get; set; }
        public int ID{ get; set; }
        public int Age{ get; set; }

    }
    
    class Program
    {
        static void Main()
        {
            List<People> peoples = new List<People>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                string[] tokens = input.Split();
                string name = tokens[0];
                int id = int.Parse(tokens[1]);
                int age= int.Parse(tokens[2]);

                People people = new People();
                people.Name = name;
                people.ID = id;
                people.Age = age;
                peoples.Add(people);

            }
            peoples = peoples.OrderBy(x => x.Age).ToList();
            foreach (People people in peoples)
            {
                Console.WriteLine($"{people.Name} with ID: {people.ID} is {people.Age} years old.");

            }


        }

    }

}


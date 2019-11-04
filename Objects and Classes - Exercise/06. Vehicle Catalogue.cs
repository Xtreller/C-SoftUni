using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Vehicles
    {


        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horses { get; set; }

    }

    class Program
    {
        static void Main()
        {
            List<Vehicles> Catalogue = new List<Vehicles>();
            double trucksHP = 0;
            double trucksCount = 0;
            double carsHP = 0;
            double carsCount = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] splitInput = input.Split();
                string type = splitInput[0];
                string Model = splitInput[1];
                string Color = splitInput[2];
                int HP = int.Parse(splitInput[3]);

                Vehicles vehicles = new Vehicles();
                if (type == "car")
                {
                    vehicles.Type = "Car";
                    carsHP += HP;
                    carsCount++;

                }
                if (type == "truck")
                {
                    vehicles.Type = "Truck";
                    trucksHP += HP;
                    trucksCount++;
                }
                vehicles.Model = Model;
                vehicles.Color = Color;
                vehicles.Horses = HP;
                Catalogue.Add(vehicles);

            }
            while (true)
            {
                string modelOrEnd = Console.ReadLine();
                if (modelOrEnd == "Close the Catalogue")
                {
                    break;
                }
                List<Vehicles> print = Catalogue.Where(x => x.Model == modelOrEnd).ToList();
                foreach (Vehicles item in print)
                {
                    Console.WriteLine("Type: " + item.Type);
                    Console.WriteLine("Model: " + item.Model);
                    Console.WriteLine("Color: " + item.Color);
                    Console.WriteLine("Horsepower: " + item.Horses);
                }

            }
            var onlyCars = Catalogue.Where(x => x.Type == "Car").ToList();
            var onlyTrucks = Catalogue.Where(x => x.Type == "Truck").ToList();
            if (onlyCars.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {(carsHP / carsCount):f2}.");

            }

            if (onlyTrucks.Count == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {(trucksHP / trucksCount):f2}.");

            }



        }

    }

}


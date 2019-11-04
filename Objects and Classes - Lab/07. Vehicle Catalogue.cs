using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
    class Catalog
    {
        public Catalog()
        {
            trucks = new List<Truck>();
            cars = new List<Cars>();
        }

        public List<Truck> trucks { get; set; }
        public List<Cars> cars { get; set; }

    }

    class Program
    {
        static void Main()
        {
            List<Catalog> List = new List<Catalog>();
            Catalog catalog = new Catalog();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] tokens = input.Split('/');
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int ValueforType = int.Parse(tokens[3]);
                if (type == "Truck")
                {

                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = ValueforType;
                    catalog.trucks.Add(truck);
                }
                if (type == "Car")
                {

                    Cars car = new Cars();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = ValueforType;
                    catalog.cars.Add(car);
                }

            }
            List<Cars> cars = catalog.cars.ToList();
            List<Truck> trucks = catalog.trucks.ToList();
            Console.WriteLine("Cars:");
            cars = cars.OrderBy(x => x.Brand).ToList();
            trucks = trucks.OrderBy(x => x.Brand).ToList();
            foreach (Cars car in cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Truck truck in trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

            }



        }

    }

}


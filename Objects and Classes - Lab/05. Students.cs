using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Globalization;

namespace mid_exam
{
    class Song
    {
        public string List { get; set; }
        public string Name { get; set; }
        public string time { get; set; }

    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "end")
                {
                    break;
                }

                var data = inputData.Split();
                Student student = new Student();
                {
                    student.FirstName = data[0];
                    student.LastNAme = data[1];
                    student.Age = int.Parse(data[2]);
                    student.HomeTown = data[3];

                }
                list.Add(student);

            }
            string town = Console.ReadLine();
            foreach (Student student in list)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} { student.LastNAme} is { student.Age} years old.");
                }
            }



        }
    }
}

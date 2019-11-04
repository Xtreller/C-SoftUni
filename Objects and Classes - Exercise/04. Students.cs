using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Students
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public decimal Grade { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Students> list = new List<Students>();
            int countOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                Students student = new Students();
                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = decimal.Parse(input[2]);
                list.Add(student);
            }
            list = list.OrderByDescending(x=>x.Grade).ToList();

            foreach (Students student in list)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }
        }

    }

}


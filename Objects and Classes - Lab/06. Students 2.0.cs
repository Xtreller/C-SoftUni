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
        static Student GetStudent(List<Student> students, string first, string last)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == first && student.LastNAme == last)
                {
                    existingStudent = student;
                }

            }
            return existingStudent;
        }

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
                
                if (IsExistingStudents(list,data[0],data[1]))
                {
                    Student student = GetStudent(list,data[0],data[1]);
                    student.FirstName = data[0];
                    student.LastNAme = data[1];
                    student.Age = int.Parse(data[2]);
                    student.HomeTown = data[3];
                }
                else
                {
                    Student student = new Student();
                    {
                        student.FirstName = data[0];
                        student.LastNAme = data[1];
                        student.Age = int.Parse(data[2]);
                        student.HomeTown = data[3];

                    }
                    list.Add(student);

                }


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
        static bool IsExistingStudents(List<Student> list, string first, string second)
        {
            foreach (Student student in list)
            {
                if (student.FirstName == first && student.LastNAme == second)
                {
                    return true;
                }
            }

            return false;

        }

    }
}

using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string comand = Console.ReadLine();
                if (comand=="End")
                {
                    break;
                }
                
                string[] tokens = comand.Split();
                
                if (tokens[0]=="Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                if (tokens[0]=="Insert")
                {
                    
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index >= numbers.Count || index<0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);

                }
                if (tokens[0]=="Remove")
                {
                    if (int.Parse(tokens[1]) >= numbers.Count || int.Parse(tokens[1])<0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(int.Parse(tokens[1]));
                   
                }
                if (tokens[0] =="Shift")
                {
                    if (tokens[1]=="left")
                    { 
                    
                        for (int i = 0; i < int.Parse(tokens[2]); i++)
                        {
                            int firstNumb = numbers[0];
                            numbers.Add(firstNumb);
                            numbers.RemoveAt(0);

                        }



                    }
                    else if(tokens[1]=="right")
                    {
                        for (int i = 0; i < int.Parse(tokens[2]); i++)
                        {
                            int lastNumb = numbers[numbers.Count-1];
                            numbers.Insert(0,lastNumb);
                            numbers.RemoveAt(numbers.Count-1);
                        }

                    }

                }



            }
            Console.WriteLine(string.Join(" ",numbers));
        }


    }
}
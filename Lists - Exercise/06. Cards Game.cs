using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();
            int iterationNumb = 1;
            while (true)
            {

                if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    break;
                }
                if (firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);

                }

               else if (firstPlayer[0] > secondPlayer[0])
                {

                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);

                }
                else if (secondPlayer[0]>firstPlayer[0])
                {

                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);

                }
                iterationNumb++;
            }
            int sum = 0;
            if (firstPlayer.Count == 0)
            {
                for (int i = 0; i < secondPlayer.Count; i++)
                {
                    sum += secondPlayer[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                for (int i = 0; i < firstPlayer.Count; i++)
                {
                    sum += firstPlayer[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");

            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace mid_exam
{

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string LongerWord = string.Empty;
            string ShorterWord = string.Empty;
            int Sum = 0;
            if (input[0].Length > input[1].Length)
            {
                LongerWord = input[0];
                ShorterWord = input[1];
                for (int i = 0; i < ShorterWord.Length; i++)
                {
                    char shorterWordChar = ShorterWord[i];
                    char longerWordChar = LongerWord[i];

                    Sum += ((int)shorterWordChar * (int)longerWordChar);
                }

                for (int p = ShorterWord.Length; p < LongerWord.Length; p++)
                {
                    char excessChar = LongerWord[p];
                    Sum += (int)excessChar;
                }

            }
           else if (input[0].Length < input[1].Length)
            {
                LongerWord = input[1];
                ShorterWord = input[0];
                for (int i = 0; i < ShorterWord.Length; i++)
                {
                    char shorterWordChar = ShorterWord[i];
                    char longerWordChar = LongerWord[i];

                    Sum += ((int)shorterWordChar * (int)longerWordChar);

                }
                for (int p = ShorterWord.Length; p < LongerWord.Length; p++)
                {
                    char excessChar = LongerWord[p];
                    Sum += (int)excessChar;
                }
            }
            if(input[0].Length == input[1].Length)
            {
                for (int i = 0; i < input[1].Length; i++)
                {
                    char shorterWordChar = input[0][i];
                    char longerWordChar = input[1][i];

                    Sum += ((int)shorterWordChar * (int)longerWordChar);

                }
            }
            Console.WriteLine(Sum);
        }

    }
}


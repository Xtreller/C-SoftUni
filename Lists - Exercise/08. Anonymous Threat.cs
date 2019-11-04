using System;
using System.Linq;
using System.Text;

using System.Collections.Generic;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> numbersAsStrings = Console.ReadLine().Split().ToList();


            while (true)
            {
                string input = Console.ReadLine();
                string[] Tokens = input.Split();
                string command = Tokens[0];
                if (input == "3:1")
                {
                    break;
                }
                else if (command == "merge")
                {

                    int startIndex = int.Parse(Tokens[1]);
                    int endIndex = int.Parse(Tokens[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex < 0 || startIndex > numbersAsStrings.Count - 1)
                    {
                        continue;
                    }
                    if (endIndex > numbersAsStrings.Count - 1)
                    {
                        endIndex = numbersAsStrings.Count - 1;
                    }
                    Merge(numbersAsStrings, startIndex, endIndex);


                }
                else
                {

                    int index = int.Parse(Tokens[1]);
                    int parts = int.Parse(Tokens[2]);

                    string element = numbersAsStrings[index];

                    numbersAsStrings.RemoveAt(index);

                    List<string> newWord = Divide(element, parts);
                    numbersAsStrings.InsertRange(index, newWord);
                }

            }
            Console.WriteLine(string.Join(" ", numbersAsStrings));


        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> newWords = new List<string>();
            int partLenght = element.Length / parts;
            int lastPartLenght = partLenght + element.Length % parts;
            for (int i = 0; i < parts; i++)
            {
                string newWord = element.Substring(i * partLenght, partLenght);
                if (i == parts - 1)
                {
                    newWord = element.Substring(i * partLenght, lastPartLenght);
                }
                newWords.Add(newWord);
            }
            return newWords;
        }

        private static void Merge(List<string> words, int startIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                string word = words[i];
                sb.Append(word);
            }
            words.RemoveRange(startIndex, endIndex - startIndex+1);
            words.Insert(startIndex, sb.ToString());

        }
    }
}
using System;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            Console.WriteLine(getVowelSum(word));
        }
        public static int getVowelSum(string str)
        {
            int sumOfVowels = 0;
            str= str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i]=='o' || str[i] == 'u' || str[i] == 'y' || str[i] == 'i')
                {
                    sumOfVowels++;
                }

            }
            return sumOfVowels;
        }
       
        
    }
}
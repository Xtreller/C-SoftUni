using System;
using System.Text;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            string password = Console.ReadLine();
            bool result = password.All(Char.IsLetterOrDigit);
            int countOfDigits = password.Count(char.IsDigit);
            if (!result)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (password.Length<6 || password.Length>10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
             if (countOfDigits<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }

        }

    }
}
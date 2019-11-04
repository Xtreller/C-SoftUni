using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string username = Console.ReadLine();
        char[] password = username.ToCharArray();
        string CorrectPass = String.Empty;
        int counter = 0;

        for (int p = password.Length - 1; p >= 0; p--)
        {
            CorrectPass += password[p];
        }
        for (int i = 0; i < int.MaxValue; i++)
        {


            string inputPass = Console.ReadLine();
            if (inputPass != CorrectPass)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");

            }

            if (inputPass == CorrectPass)
            {
                Console.WriteLine($"User {username} logged in.");
                return;
            }


        }


    }
}
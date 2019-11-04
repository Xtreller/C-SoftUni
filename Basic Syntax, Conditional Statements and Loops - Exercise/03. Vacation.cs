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
        int membCount = int.Parse(Console.ReadLine());
        string PplType = Console.ReadLine();
        string Day = Console.ReadLine();
        double price = 0;
        double totalPrice = 0;

        if (Day == "Friday")
        {
            switch (PplType)
            {
                case "Students":
                    price = 8.45;
                    if (membCount >= 30)
                    {
                        totalPrice = price * membCount;
                        totalPrice = totalPrice - (totalPrice * 0.15);
                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                case "Business":
                    price = 10.90;
                    if (membCount >= 100)
                    {
                        membCount -= 10;
                        totalPrice = membCount * price;
                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                case "Regular":
                    price = 15;
                    if (membCount >= 10 && membCount <= 20)
                    {
                        totalPrice = membCount * price;
                        totalPrice -= (totalPrice * 0.05);
                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                default:
                    break;
            }
        }
       else if (Day == "Saturday")
        {
            switch (PplType)
            {
                case "Students":
                    price = 9.80;
                    if (membCount >= 30)
                    {
                        totalPrice = price * membCount;
                        totalPrice = totalPrice - (totalPrice * 0.15);
                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                case "Business":
                    price = 15.60;
                    if (membCount >= 100)
                    {
                        membCount -= 10;
                        totalPrice = membCount * price;
                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                case "Regular":
                    price = 20;
                    if (membCount >= 10 && membCount <= 20)
                    {
                        totalPrice = membCount * price;
                        totalPrice -= (totalPrice * 0.05);
                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                default:
                    break;
            }
        }
        else if (Day == "Sunday")
        {
            switch (PplType)
            {
                case "Students":
                    price = 10.46;
                    if (membCount >= 30)
                    {
                        totalPrice = price * membCount;
                        totalPrice = totalPrice - (totalPrice * 0.15);

                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                case "Business":
                    price = 16;
                    if (membCount >= 100)
                    {
                        membCount -= 10;
                        totalPrice = membCount * price;
                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                case "Regular":
                    price = 22.50;
                    if (membCount >= 10 && membCount <= 20)
                    {
                        totalPrice = membCount * price;
                        totalPrice -= (totalPrice * 0.05);
                    }
                    else
                    {
                        totalPrice = membCount * price;
                    }
                    break;
                default:
                    break;
            }
        }
        
        
        Console.WriteLine($"Total price: {totalPrice:f2}"); 
        


    }
}
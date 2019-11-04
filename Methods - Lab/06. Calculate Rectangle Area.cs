using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
         double width = double.Parse(Console.ReadLine());
         double height = double.Parse(Console.ReadLine());
          Console.WriteLine(rectangleArea(width,height));
        }
        public static double rectangleArea(double width,double height)
        {
        
         return width *height;
            
        }
        
    }
} 
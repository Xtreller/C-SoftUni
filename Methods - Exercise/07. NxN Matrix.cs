using System;
using System.Text;
using System.Linq;

namespace _07.magic_number
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            row(n);
            
        }
        public static string Line(int n)
        {
            string res = string.Empty;
            
                for (int i = 0; i < n; i++)
                {
                    res += n + " ";
                }
            
            return res;
        }
        public static string[] row(int n)
        {
            string[] rows = new string[n];
            for (int i = 0; i < n; i++)
            {
                rows[i] = Line(n);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(rows[i]);
            }
            return rows;
        }

    }
}
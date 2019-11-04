using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        while (nums.Length > 1)
        {
            int[] sum = new int[nums.Length - 1];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                sum[i] = nums[i] + nums[i + 1];
            }
            nums = sum;
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question46
    {
        public static void Q46()
        {
            Console.Write("Input an integer:");  
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            Console.WriteLine( (nums[0] == x) || (nums[nums.Length - 1] == x));
        }
    }
}
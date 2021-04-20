using System;

namespace C_Sharp_Basic
{
    public class Question45
    {
        public static void CountNumber()
        {
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            Console.Write("Input an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == num) count++;
            }
            Console.WriteLine("Number of {0} present in the said array: {1}", num, count);
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question47
    {
        public static void SumOfArray()
        {
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int sum = 0;
            for (int i = 0; i < nums.Length; i++) {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
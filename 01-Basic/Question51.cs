using System;

namespace C_Sharp_Basic
{
    public class Question51
    {
        public static void Q51()
        {
            int[] nums = {1, 2, 5, 7, 8};
            int max = 0;
            if (nums[0] > nums[nums.Length - 1]) {
                max = nums[0];
            } else {
                max = nums[nums.Length - 1];
            }
            Console.WriteLine("Highest value between first and last values of the said array: {0}", max);
        }
    }
}
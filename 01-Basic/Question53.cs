using System;

namespace C_Sharp_Basic
{
    public class Question53
    {
        public static void ArrayContainsOdd()
        {
            int[] nums = {2, 4, 7, 8, 6};
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] % 2 != 0) {
                    Console.WriteLine(true);
                } else Console.WriteLine(false);
            }
        }
    }
}
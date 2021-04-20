using System;

namespace C_Sharp_Basic
{
    public class Question50
    {
        public static void RotateArray()
        {
            int[] nums = {1, 2, 8};
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", nums));
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question49
    {
        public static void Q49()
        {
            int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int[] nums2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};
            
            Console.WriteLine("Check if the first element or the last element of the two arrays ( length 1 or more) are equal.");
            Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
        }
    }
}
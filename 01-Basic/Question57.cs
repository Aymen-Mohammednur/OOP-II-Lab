using System;

namespace C_Sharp_Basic
{
    public class Question57
    {
        public static void Q57()
        {
            int[] arr = {1, 3, 4, 5, 2};
            Console.WriteLine(AdjacentElementsProduct(arr));
        }
        public static int AdjacentElementsProduct(int[] arr)
        {
            int max = arr[0] * arr[1];
            for (int i = 1; i <= arr.Length - 2; i++) {
                max = Math.Max(max, arr[i] * arr[i + 1]);
            }
            return max;
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question59
    {
        public static void Q59()
        {
            int[] arr = {1, 3, 5, 6, 9};
            Console.WriteLine(IncreasingSequence(arr));
        }

        public static bool IncreasingSequence(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++) {
                if (arr[i] >= arr[i + 1]) count++;
                if (i + 2 < arr.Length && arr[i] >= arr[i + 2]) count++;
            }
            return count <= 2;
        }
    }
}
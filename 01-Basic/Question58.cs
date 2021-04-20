using System;

namespace C_Sharp_Basic
{
    public class Question58
    {
        public static void Q58()
        {
            int[] arr = {1, 3, 5, 6, 9};
            Console.WriteLine(IntegersNeeded(arr));
        }

        public static int IntegersNeeded(int[] arr)
        {
            Array.Sort(arr);
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++) {
                count += arr[i + 1] - arr[i] -1;
            }
            return count;
        }
    }
}
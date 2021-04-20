using System;

namespace C_Sharp_Basic
{
    public class Question31
    {
        public static void MultiplyArray()
        {
            int[] array1 = new int[] {1, 3, -5, 4};
            int[] array2 = new int[] {1, 4, -5, -2};

            Console.WriteLine("Multiply corresponding elements of two arrays: ");
            for (int i = 0; i < array1.Length; i++) {
                Console.Write(array1[i] * array2[i] + " ");
            }
        }
    }
}
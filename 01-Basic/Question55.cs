using System;

namespace C_Sharp_Basic
{
    public class Question55
    {
        public static void LargestProduct()
        {
            int[] arr = {6, 1, 12, 3, 1, 4};
            Console.WriteLine(ProductOfAdjacent(arr) == 36);
        }

        public static int ProductOfAdjacent(int[] arr)
        {
            int index = 0;
            int product = arr[index] * arr[index + 1];
            index++;

            while (index + 1 < arr.Length) {
                product = ((arr[index] * arr[index + 1]) > product) ? (arr[index + 1] * arr[index]) : product;
                index++;
            }
            return product;
        }
    }
}
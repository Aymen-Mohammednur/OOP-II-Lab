using System;

namespace C_Sharp_Basic
{
    public class Question52
    {
        public static void Q52()
        {
            int[] array1 = {1, 2, 5};
            int[] array2 = {0, 3, 8};
            int[] array3 = {-1, 0, 2};
            
            int[] new_array = { array1[1], array2[1], array3[1] };
            Console.WriteLine("New array: [{0}]", string.Join(", ", new_array));
        }
    }
}
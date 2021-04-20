using System;

namespace C_Sharp_Basic
{
    public class Question16
    {
        public static void ChangePosition()
        {
            string str1 = "w3resource";
            string str2 = "Python";
            Console.WriteLine("Original Words:");
            Console.WriteLine($"{str1}\n{str2}");
            Console.WriteLine("After Swapping:");
            Console.WriteLine(SwapFirstandLast(str1));
            Console.WriteLine(SwapFirstandLast(str2));
        }

        static string SwapFirstandLast(string str)
        {
            char first = str[0];
            char last = str[str.Length - 1];
            return last + str.Substring(1, str.Length - 2) + first;
        }
    }
}
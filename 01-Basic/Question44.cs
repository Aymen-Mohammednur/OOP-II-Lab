using System;

namespace C_Sharp_Basic
{
    public class Question44
    {
        public static void Q44()
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            string newString = "";

            for (int i = 0; i < input.Length; i++) {
                if (i % 2 == 0) newString += input[i];
            }

            Console.WriteLine(newString);
        }
    }
}
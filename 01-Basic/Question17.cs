using System;

namespace C_Sharp_Basic
{
    public class Question17
    {
        public static void AddFirstChar()
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            char firstChar = input[0];
            Console.WriteLine($"{firstChar}{input}{firstChar}");
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question32
    {
        public static void FourCopies()
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            if (input.Length < 4) {
                Console.WriteLine(input);
            } else {
                string substring = input.Substring(input.Length - 4);
                string fourCopies = substring + substring + substring + substring;
                Console.WriteLine(fourCopies);
            }
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question56
    {
        public static void IsPalindrome()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            bool isPalindrome = new string(charArray).Equals(input);
            Console.WriteLine(isPalindrome);
        }
    }
}
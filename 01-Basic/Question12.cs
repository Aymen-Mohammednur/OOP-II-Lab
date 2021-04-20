using System;

namespace C_Sharp_Basic
{
    public class Question12
    {
        public static void Display4Times()
        {
            Console.Write("Enter a digit: ");
            string digit = Console.ReadLine();
            for (int i = 0; i <= 1; i++) {
                Console.WriteLine("{0} {1} {2} {3}", digit, digit, digit, digit);
                Console.WriteLine("{0}{1}{2}{3}", digit, digit, digit, digit);
            }
        }
    }
}
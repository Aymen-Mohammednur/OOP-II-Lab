using System;

namespace C_Sharp_Basic
{
    public class Question27
    {
        public static void SumOfDigits()
        {
            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number != 0) {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Sum of the digits of the said integer: {sum}");
        }
    }
}
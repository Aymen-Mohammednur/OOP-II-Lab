using System;

namespace C_Sharp_Basic
{
    public class Question2
    {
        public static void SumOfTwo()
        {
            Console.Write("Enter the first number: ");
            decimal fNum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the second number: ");
            decimal sNum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"The sum is {fNum + sNum}");
        }
    }
}
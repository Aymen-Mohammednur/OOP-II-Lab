using System;

namespace C_Sharp_Basic
{
    public class Question3
    {
        public static void DivOfTwo()
        {
            Console.Write("Enter the first number: ");
            decimal fNum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the second number: ");
            decimal sNum = Convert.ToDecimal(Console.ReadLine());
            if (sNum == 0) {
                Console.WriteLine("Can not divide by zero!");
            }
            else {
                Console.WriteLine($"The quotient is {fNum / sNum}");
            }
        }
    }
}
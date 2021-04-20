using System;

namespace C_Sharp_Basic
{
    public class Question8
    {
        public static void MultiplicationTable()
        {
            Console.Write("Enter the number: ");
            decimal number = Convert.ToDecimal(Console.ReadLine());

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question9
    {
        public static void Average()
        {
            Console.Write("Enter the first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the third number: ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            decimal num4 = Convert.ToDecimal(Console.ReadLine());

            decimal average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}");
        }
    }
}
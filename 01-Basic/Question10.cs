using System;

namespace C_Sharp_Basic
{
    public class Question10
    {
        public static void Q10()
        {
            Console.Write("Enter the first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the third number: ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());

            decimal a = (num1 + num2) * num3;
            decimal b = (num1 * num2) + (num2 * num3);
            Console.WriteLine($"Result of specified numbers {num1}, {num2} and {num3}, (x+y).z is {a} and x.y + y.z is {b}");
        }
    }
}
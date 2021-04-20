using System;

namespace C_Sharp_Basic
{
    public class Question36
    {
        public static void RangeChecker()
        {
            Console.Write("Input first number (<100): ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number (>200): ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((fNum >= -10 && fNum <= 10) || (sNum >= -10 && sNum <= 10));
        }
    }
}
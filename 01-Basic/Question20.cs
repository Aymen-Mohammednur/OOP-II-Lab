using System;

namespace C_Sharp_Basic
{
    public class Question20
    {
        public static void Q20()
        {
            Console.Write("Input first number: ");
            decimal fNum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Input second number: ");
            decimal sNum = Convert.ToDecimal(Console.ReadLine());

            decimal diff = fNum - sNum;
            decimal absValue = diff > 0 ? diff : -1 * diff;
            if (fNum > sNum) {
                Console.WriteLine(2 * absValue);
            }
            else {
                Console.WriteLine(absValue);
            }
        }
    }
}
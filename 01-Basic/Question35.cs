using System;

namespace C_Sharp_Basic
{
    public class Question35
    {
        public static void CheckNumbers()
        {
            Console.Write("Input first number (<100): ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number (>200): ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            if (fNum < 100 || sNum > 200) {
                Console.WriteLine(true);
            } else {
                Console.WriteLine(false);
            }
        }
    }
}
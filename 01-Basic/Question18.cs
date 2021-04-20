using System;

namespace C_Sharp_Basic
{
    public class Question18
    {
        public static void CheckIfNegative()
        {
            Console.Write("Input first integer: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            if (fNum * sNum < 0) {
                Console.WriteLine(true);
            }
            else {
                Console.WriteLine(false);
            }
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question19
    {
        public static void SumIfEqual()
        {
            Console.Write("Input first integer: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            int sum = fNum + sNum;
            if (fNum == sNum) {
                Console.WriteLine(3 * sum);
            }
            else {
                Console.WriteLine(sum);
            }
        }
    }
}
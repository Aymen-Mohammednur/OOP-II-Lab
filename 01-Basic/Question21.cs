using System;

namespace C_Sharp_Basic
{
    public class Question21
    {
        public static void CheckSum()
        {
            Console.Write("Input first integer: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            int sum = fNum + sNum;
            if (sum == 20 || (sum) % 20 == 0) {
                Console.WriteLine(true);
            } 
            else {
                Console.WriteLine(false);
            }
        }
    }
}
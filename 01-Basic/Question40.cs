using System;

namespace C_Sharp_Basic
{
    public class Question40
    {
        public static void NearestTo20()
        {
            Console.Write("Input first number: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            int absFNum = Math.Abs(fNum - 20);
            int absSNum = Math.Abs(sNum - 20);

            if (fNum == sNum) {
                Console.WriteLine(0);
            }
            else if (absFNum > absSNum) {
                Console.WriteLine(absSNum);
            }
            else {
                Console.WriteLine(absFNum);
            }
        }
    }
}
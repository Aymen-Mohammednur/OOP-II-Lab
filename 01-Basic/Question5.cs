using System;

namespace C_Sharp_Basic
{
    public class Question5
    {
        public static void Swapping()
        {
            Console.Write("Input the First Number: ");
            decimal fNum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            decimal sNum = Convert.ToDecimal(Console.ReadLine());
            decimal temp;
            temp = sNum;
            sNum = fNum;
            fNum = temp;
            Console.WriteLine("After Swapping: ");
            Console.WriteLine($"First Number: {fNum}");
            Console.WriteLine($"Second Number: {sNum}");
        }
    }
}
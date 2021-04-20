using System;

namespace C_Sharp_Basic
{
    public class Question6
    {
        public static void Multiplication()
        {
            Console.Write("Input the first number to multiply: ");
            decimal fNum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            decimal sNum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            decimal tNum = Convert.ToDecimal(Console.ReadLine());

            decimal product = fNum * sNum * tNum;
            Console.WriteLine($"{fNum} x {sNum} x {tNum} = {product}");
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question7
    {
        public static void Q7()
        {
            Console.Write("Input the first number: ");
            decimal fNum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Input the second number: ");
            decimal sNum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"{fNum} + {sNum} = {fNum + sNum}");
            Console.WriteLine($"{fNum} - {sNum} = {fNum - sNum}");
            Console.WriteLine($"{fNum} * {sNum} = {fNum * sNum}");
            Console.WriteLine($"{fNum} / {sNum} = {fNum / sNum}");
            Console.WriteLine($"{fNum} mod {sNum} = {fNum % sNum}");
        }
    }
}
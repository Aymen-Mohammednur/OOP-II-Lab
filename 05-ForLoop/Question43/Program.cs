using System;

namespace Question43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number for HCF: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number for HCF: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The HCF of {num1} and {num2} is {helper(num1, num2)}");

            static int helper(int num1, int num2) {
                 while (num1 != 0 && num2 != 0)
                {
                    if (num1 > num2)
                        num1 %= num2;
                    else
                        num2 %= num1;
                }

                return num1 | num2;
            }
        }
    }
}

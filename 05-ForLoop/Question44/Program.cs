using System;

namespace Question44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number for HCF: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number for HCF: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int lcm = (num1 * num2) / hcf(num1, num2);
            Console.WriteLine($"The LCM of {num1} and {num2} is {lcm}");


        }
        static int hcf(int num1, int num2) 
        {
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

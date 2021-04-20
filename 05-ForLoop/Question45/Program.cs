using System;

namespace Question45
{
    class Program
    {
        static void Main(string[] args)
        {   
            int i, lcm = 1;
            Console.Write("Input the first number for HCF: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number for HCF: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int max = (num1 > num2) ? num1 : num2;
            for (i = max; ; i += max) {
                if (i % num1 == 0 && i % num2 == 0) {
                    lcm = i;
                    break;
                }
            }
            Console.WriteLine($"The LCM of {num1} and {num2} is {lcm}");
        }
    }
}

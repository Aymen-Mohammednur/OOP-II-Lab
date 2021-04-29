using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            decimal fact = Factorial(num);
            Console.WriteLine("The factorial of {0} is {1}", num, fact);
        }

        static decimal Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}

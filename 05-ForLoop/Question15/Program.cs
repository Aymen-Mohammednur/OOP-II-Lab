using System;

namespace Question15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f = 1, num;

            Console.Write("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("The Factorial of {0} is: {1}\n", num, f);
        }
    }
}

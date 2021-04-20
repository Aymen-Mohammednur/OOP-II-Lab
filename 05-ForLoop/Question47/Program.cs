using System;

namespace Question47
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, n1, s1 = 0, j, factorial;

            Console.Write("Input a number to check whether it is Strong number: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;

            for (j = n; j > 0; j = j / 10)
            {

                factorial = 1;
                for (i = 1; i <= j % 10; i++)
                {
                    factorial = factorial * i;
                }
                s1 = s1 + factorial;

            }

            if (s1 == n1)
            {
                Console.Write("\n{0} is Strong number.\n\n", n1);
            }
            else
            {
                Console.Write("\n{0} is not Strong number.\n\n", n1);
            }
        }
    }
}

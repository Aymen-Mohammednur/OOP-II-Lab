using System;

namespace Question24
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double x, sum, ctr, p, term;

            Console.Write("Input the value of x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            term = 1;
            sum = 0;
            for (i = 1, p = 1; i < n + 1; i++)
            {
                ctr = Math.Pow(x, p);
                sum = sum + ctr * term;
                term = term * (-1);
                p = p + 2;
            }
            Console.Write("\nThe sum = {0}\nNumber of terms = {1}\n The value of x = {2}\n", sum, n, x);
        }
    }
}

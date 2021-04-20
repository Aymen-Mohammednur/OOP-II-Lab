using System;

namespace Question18
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, sum, t, d;
            int i, n;

            Console.Write("Input the Value of x :");

            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 1; t = 1;
            for (i = 1; i < n; i++)
            {
                d = (2 * i) * (2 * i - 1);
                t = -t * x * x / d;
                sum = sum + t;
            }
            Console.Write("\nthe sum = {0}\nNumber of terms = {1}\nvalue of x = {2}\n", sum, n, x);
        }
    }
}

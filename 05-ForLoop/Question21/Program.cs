using System;

namespace Question21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, t = 9, sum = 0;

            Console.Write("Input the number or terms :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum += t;
                Console.Write("{0}   ", t);
                t = t * 10 + 9;
            }
            Console.Write("\nThe sum of the series = {0} \n", sum);
        }
    }
}

using System;

namespace Question22
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, p, q;

            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                { p = 1; q = 0; }
                else
                { p = 0; q = 1; }
                for (j = 1; j <= i; j++)
                    if (j % 2 == 0)
                        Console.Write("{0}", p);
                    else
                        Console.Write("{0}", q);
                Console.Write("\n");
            }
        }
    }
}

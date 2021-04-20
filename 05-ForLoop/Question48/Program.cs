using System;

namespace Question48
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n1, s1 = 0, j, k, en, sn, factorial;

            Console.Write("Input starting range of number : ");
            sn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending range of number: ");
            en = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nThe Strong numbers are :\n");

            for (k = sn; k <= en; k++)
            {
                n1 = k;
                s1 = 0;

                for (j = k; j > 0; j = j / 10)
                {

                    factorial = 1;
                    for (i = 1; i <= j % 10; i++)
                    {
                        factorial = factorial * i;
                    }
                    s1 = s1 + factorial;
                }

                if (s1 == n1)

                    Console.Write("{0}  ", n1);
            }
        }
    }
}

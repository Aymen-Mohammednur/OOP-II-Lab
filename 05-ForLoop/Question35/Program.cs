using System;

namespace Question35
{
    class Program
    {
        static void Main(string[] args)
        {
            int prv = 0, pre = 1, trm, i, n;

            Console.Write("Input number of terms to be display : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Here is the fibonacci series upto  to {0} terms : \n", n);
            Console.Write("{0}    {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }
        }
    }
}

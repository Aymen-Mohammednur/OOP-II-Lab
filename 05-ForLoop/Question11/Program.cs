using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", i);
                Console.Write("\n");
            }
        }
    }
}

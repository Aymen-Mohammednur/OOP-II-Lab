using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows, k = 1;
            
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }
        }
    }
}

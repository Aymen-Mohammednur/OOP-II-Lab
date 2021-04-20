using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number (table to be calculated): ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}

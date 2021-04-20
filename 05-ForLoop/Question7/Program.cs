using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input uptp the table number starting from 1: ");
            int upto = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j <= upto; j++)
                {
                    Console.WriteLine($"{j} X {i} = {j * i} ");
                }
            }
        }
    }
}

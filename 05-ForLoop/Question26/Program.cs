using System;

namespace Question26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of Series");

            Console.Write($"Input the number: ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int series = 1;
            int sum = 0;

            for(int i = 1; i<=terms; i++)  
            {
                Console.Write($"{series} + ");
                sum+=series;
                series=(series*10)+1;
            }          
            Console.Write("The sum is {0}\n", sum);   
        }
    }
}

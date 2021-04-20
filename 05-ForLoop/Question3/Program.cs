using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                sum += i;
            }
            System.Console.WriteLine(sum);
        }
    }
}

using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of terms: ");
            int noOfTerms = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("The odd numbers are: ");
            for (int i = 1; i <= noOfTerms; i++) {
                sum += 2 * i - 1;
                Console.Write($"{2 * i - 1} ");
            }
            Console.WriteLine($"\nThe sum is: {sum}");
        }
    }
}

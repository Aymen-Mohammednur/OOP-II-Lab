using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] arr = new int[10];
            for (int i = 1; i < 11; i++)
            {
                Console.Write("Element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                sum += i;
            }
            double average = sum / 10;
            System.Console.WriteLine($"Sum is {sum}, Average is {average}");
        }
    }
}

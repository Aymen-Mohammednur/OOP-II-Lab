using System;

namespace Question42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int permNum = num;
            int temp = 1;
            int dec = 0;
            int j = 1;
            int remainder;
            for (int i = num; i > 0; i = i / 10) {
                remainder = i % 10;
                if (j == 1) temp *= 1;
                else temp *= 2;
                dec = dec + (remainder + temp);
                j++;
            }
            Console.WriteLine($"The decimal of {permNum} is {dec}");
        }
    }
}

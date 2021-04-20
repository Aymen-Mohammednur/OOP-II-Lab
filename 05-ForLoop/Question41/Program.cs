using System;

namespace Question41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int permNum = num;
            string binary = "";
            while (num > 1) {
                int remainder = num % 2;
                binary = Convert.ToString(remainder) + binary;
                num /= 2;
            }
            binary = Convert.ToString(num) + binary;
            Console.WriteLine($"The binary of {permNum} is {binary}");
        }
    }
}

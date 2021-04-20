using System;

namespace Question37
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, t;

            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
        }
    }
}

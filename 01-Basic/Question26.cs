using System;

namespace C_Sharp_Basic
{
    public class Question26
    {
        public static void SumOfPrime()
        {
            int sum = 0;
            int count = 0;
            int number = 2;
            while (count < 500) {
                if (isPrime(number)) {
                    sum += number;
                    count++;
                }
                number++;
            }
            Console.WriteLine("Sum of the first 500 prime numbers: ");
            Console.WriteLine(sum);
        }

        public static bool isPrime(int number)
        {
            if (number == 2) return true;
            
            int a = Convert.ToInt32(Math.Floor(Math.Sqrt(number)));
            for (int i = 2; i <= a; ++i) {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
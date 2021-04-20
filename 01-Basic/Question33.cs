using System;

namespace C_Sharp_Basic
{
    public class Question33
    {
        public static void MultipleOf3Or7()
        {
            Console.Write("Input an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 || number % 7 == 0) {
                Console.WriteLine(true);
            } else {
                Console.WriteLine(false);
            }
        }
    }
}
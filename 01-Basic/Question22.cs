using System;

namespace C_Sharp_Basic
{
    public class Question22
    {
        public static void CheckWithin20()
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(number - 100) <= 20 || Math.Abs(number - 200) <= 20) {
                Console.WriteLine(true);
            }
            else {
                Console.WriteLine(false);
            }
        
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question13
    {
        public static void Rectangle()
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            for(int i = 0; i < 5; i++){
                if (i == 1 || i == 2 || i == 3) {
                    Console.WriteLine($"{number} {number}");
                } else {
                    Console.WriteLine($"{number}{number}{number}");
                }
            }
        }
    }
}
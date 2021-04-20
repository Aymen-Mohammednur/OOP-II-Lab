using System;

namespace C_Sharp_Basic
{
    public class Question34
    {
        public static void StartWithSpecifiedWord()
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();

            if (str.StartsWith("Hello")) {
                Console.WriteLine(true);
            } else {
                Console.WriteLine(false);
            }
        }
    }
}
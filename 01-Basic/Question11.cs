using System;

namespace C_Sharp_Basic
{
    public class Question11
    {
        public static void PrintAge()
        {
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("You look older than {0}", age);
        }
    }
}
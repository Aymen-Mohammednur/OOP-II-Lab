using System;

namespace C_Sharp_Basic
{
    public class Question15
    {
        public static void RemoveCharacter()
        {   
            string myString = "w3resource";
            Console.WriteLine("Word: w3resource");
            Console.Write("Enter a character to remove: ");
            char myChar = Convert.ToChar(Console.ReadLine());
            int index = myString.IndexOf(myChar);
            Console.WriteLine($"{myString.Substring(0, index) + myString.Substring(index+1)}");
        }
    }
}
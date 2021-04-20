using System;

namespace C_Sharp_Basic
{
    public class Question37
    {
        public static void CheckHP()
        {
            string str= "PHP Tutorial";
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
        }
    }
}
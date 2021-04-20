using System;

namespace C_Sharp_Basic
{
    public class Question24
    {
        public static void LongestWord()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new[] { ' ' });
            string word = "";
            int count = 0;
            foreach (string s in words)
            {
                if (s.Length > count) {
                    word = s;
                    count = s.Length;
                }
            }
            Console.WriteLine(word);
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question28
    {
        public static void ReverseWords()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string reversed = "";
            string[] words = sentence.Split(new [] {" "}, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--) {
                reversed += words[i] + " ";
            }
            Console.WriteLine(reversed);
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question41
    {
        public static void a()
        {
            Console.Write("Input a string (conatins at least one 'w' char) : ");
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == 'w') count++;
            }
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count>=1 && count <= 3);
        }
    }
}
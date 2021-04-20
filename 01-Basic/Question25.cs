using System;

namespace C_Sharp_Basic
{
    public class Question25
    {
        public static void PrintOddNumbers()
        {
            for(int i = 0; i < 100; i++) {
                if (i % 2 !=0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
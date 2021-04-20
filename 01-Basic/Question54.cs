using System;

namespace C_Sharp_Basic
{
    public class Question54
    {
        public static int Helper(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        public static void CenturyFromYear() {
            Console.WriteLine(Helper(2021));
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question39
    {
        public static void MinAndMax()
        {
            Console.Write("Input first integer:");  
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer:");  
            int sNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third integer:");  
            int tNum = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine("Largest of three: "+Math.Max(fNum, Math.Max(sNum, tNum)));
            Console.WriteLine("Lowest of three: "+Math.Min(fNum, Math.Min(sNum, tNum)));
        }
    }
}
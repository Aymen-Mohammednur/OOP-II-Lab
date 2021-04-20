using System;

namespace Question71
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Row = 0; Row < 7; Row++)  
            {  
                for (int Col = 0; Col < 7; Col++)  
                {  
                    if (Col == 1 || Col == 5 || (Row == Col && Col != 0 && Col != 6))  
                        Console.Write("*");  
                    else  
                        Console.Write(" ");  
                }  
                Console.WriteLine();  
            }
        }
    }
}

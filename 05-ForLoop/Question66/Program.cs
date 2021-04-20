using System;

namespace Question66
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Row = 0; Row < 7; Row++)  
            {  
                for (int Col = 0; Col < 7; Col++)  
                {  
                    if (Col == 3 || (Row == 0 && Col > 0 && Col < 6) || (Row == 6 && Col > 0 && Col < 6))  
                        Console.Write("*");  
                    else  
                        Console.Write(" ");  
                }  
                Console.WriteLine();  
            }
        }
    }
}

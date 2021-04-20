using System;

namespace Question60
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Row = 0; Row < 7; Row++)  
            {  
                for (int Col = 0; Col < 7; Col++)  
                {  
                    if ((Col == 1 && (Row != 0 && Row != 6)) || ((Row == 0 || Row == 6) && (Col > 1 && Col < 5)) || (Col == 5 && (Row == 1 || Row == 5)))  
                        Console.Write("*");  
                    else  
                        Console.Write(" ");  
                }  
                Console.WriteLine();  
            }
        }
    }
}

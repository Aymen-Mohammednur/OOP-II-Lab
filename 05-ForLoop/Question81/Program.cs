using System;

namespace Question81
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Row = 0; Row < 7; Row++)  
            {  
                for (int Col = 0; Col < 7; Col++)  
                {  
                    if (((Col == 1 || Col == 5) && (Row > 4 || Row < 2)) || Row == Col && Col > 0 && Col < 6 || (Col == 2 && Row == 4) || (Col == 4 && Row == 2))  
                        Console.Write("*");  
                    else  
                        Console.Write(" ");  
                }  
                Console.WriteLine();  
            }
        }
    }
}

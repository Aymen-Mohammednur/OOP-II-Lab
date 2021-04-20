using System;

namespace Question82
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Row = 0; Row < 7; Row++)  
            {  
                for (int Col = 0; Col < 7; Col++)  
                {  
                    if (((Col == 1 || Col == 5) && Row < 2) || Row == Col && Col > 0 && Col < 4 || (Col == 4 && Row == 2) || ((Col == 3) && Row > 3))  
                        Console.Write("*");  
                    else  
                        Console.Write(" ");  
                }  
                Console.WriteLine();  
            }
        }
    }
}

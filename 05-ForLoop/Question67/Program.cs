using System;

namespace Question67
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Row = 0; Row < 7; Row++)  
            {  
                for (int Col = 0; Col < 7; Col++)  
                {  
                    if ((Col == 4 && Row != 6) || (Row == 0 && Col > 2 && Col < 6) || (Row == 6 && Col == 3) || (Row == 5 && Col == 2))  
                        Console.Write("*");  
                    else  
                        Console.Write(" ");  
                }  
                Console.WriteLine();  
            }
        }
    }
}

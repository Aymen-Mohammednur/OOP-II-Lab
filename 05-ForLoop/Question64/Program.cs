using System;

namespace Question64
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++) 
                {
                    if ((col == 1 && row != 0 && row != 6) || ((row == 0 || row == 6) && col > 1 && col < 5) || (row == 3 && col > 2 && col < 6) || (col == 5 && row != 0 && row != 2 && row != 6))  
                        Console.Write("*");  
                    else  
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

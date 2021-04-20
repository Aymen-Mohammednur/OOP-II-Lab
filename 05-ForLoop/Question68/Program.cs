using System;

namespace Question68
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;  
            j = 5;  
            i = 0;  
            for (int Row = 0; Row < 7; Row++)  
            {  
                for (int Col = 0; Col < 7; Col++)  
                {  
  
                    if (Col == 1 || ((Row == Col + 1) && Col != 0))  
                    {  
                        Console.Write("*");  
                    }  
                    else if (Row == i && Col == j)  
                    {  
                        Console.Write("*");  
                        i++;  
                        j--;  
                    }  
                    else  
                        Console.Write(" ");  
                }  
                Console.WriteLine();  
            }
        }
    }
}

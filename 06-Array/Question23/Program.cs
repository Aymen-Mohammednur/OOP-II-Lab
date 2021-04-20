using System;

namespace Question23
{
    class Program
    {
        static void Main(string[] args)
        {   
            int sum = 0;
            Console.Write("Input the size of the matrix: ");
            int sizeMatrix = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[sizeMatrix,sizeMatrix];

            for (int i = 0; i < sizeMatrix; i++)
            {   
                for (int j = 0; j < sizeMatrix; j++)
                {
                    Console.Write("Element - [{0}],[{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                     if (i == j) {
                         sum += arr[i, j];
                     }
                }      
            }

            System.Console.WriteLine("Sum of diagonal elements: {0}", sum);
        }
    }
}

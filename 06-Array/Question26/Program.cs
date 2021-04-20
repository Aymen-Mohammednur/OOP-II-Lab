using System;

namespace Question26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the matrix: ");
            int sizeMatrix = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[sizeMatrix,sizeMatrix];

            for (int i = 0; i < sizeMatrix; i++)
            {   
                for (int j = 0; j < sizeMatrix; j++)
                {
                    Console.Write("Element - [{0}],[{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                     if (i > j) {
                         arr[i, j] = 0;
                     }
                }      
            }

            for (int i = 0; i < sizeMatrix; i++)
            {   
                for (int j = 0; j < sizeMatrix; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }      
            }
        }
    }
}

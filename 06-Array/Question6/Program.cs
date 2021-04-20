using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int numOfElements = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[numOfElements];
            
            for (int i = 0; i < numOfElements; i++)
            {   
                Console.Write("Element - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

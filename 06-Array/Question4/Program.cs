using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int numOfElements = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[numOfElements];
            int[] arr2 = new int[numOfElements];
            
            for (int i = 0; i < numOfElements; i++)
            {   
                Console.Write("Element - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numOfElements; i++)
            {
                arr2[i] = arr1[i];
            }
        }
    }
}

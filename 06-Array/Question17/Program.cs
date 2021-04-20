using System;

namespace Question17
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

            int first, second, arrSize = arr.Length;
            first = second = int.MaxValue;

            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] < first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] < second && arr[i] != first) second = arr[i];
            }

            Console.WriteLine($"The second smallest element is {second}");
        }
    }
}

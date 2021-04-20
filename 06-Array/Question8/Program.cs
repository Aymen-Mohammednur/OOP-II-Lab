using System;

namespace Question8
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
            
            helper(arr);

            static void helper(int[] arr) {
                for (int i = 0; i < arr.Length; i++) 
                {
                    int count = 0;
                    for (int j = 0; j < arr.Length; j++) 
                    {
                        if (arr[i] == arr[j]) count += 1;
                    }
                    Console.WriteLine(+ arr[i] + " occurs " + count + " times");
                }
            }
        }
    }
}

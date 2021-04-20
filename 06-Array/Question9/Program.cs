using System;

namespace Question9
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

            int mx = arr[0];
            int mn = arr[0];

            for(int i=1; i<numOfElements; i++)
            {
                if(arr[i]>mx)
                {
                    mx = arr[i];
                }


                if(arr[i]<mn)
                {
                    mn = arr[i];
                }
            }

            Console.Write("Maximum element is : {0}\n", mx);
            Console.Write("Minimum element is : {0}\n\n", mn);
        }
    }
}

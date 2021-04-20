using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {   
            int i,j=0,k=0;
            Console.Write("Input the number of elements to be stored in the array: ");
            int numOfElements = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[numOfElements];
            int[] arr2 = new int[numOfElements];
            int[] arr3 = new int[numOfElements];
            
            for ( i = 0; i < numOfElements; i++)
            {   
                Console.Write("Element - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i=0;i<numOfElements;i++)
            {
                if (arr1[i]%2 == 0)
                {
                arr2[j] = arr1[i];
                j++;
                }
                else
                {
                arr3[k] = arr1[i];
                k++;
                }
            }

            Console.Write("\nThe Even elements are : \n");
            for(i=0;i<j;i++)
            {
                Console.Write("{0} ",arr2[i]);
            }

            Console.Write("\nThe Odd elements are :\n");
            for(i=0;i<k;i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
        }
    }
}

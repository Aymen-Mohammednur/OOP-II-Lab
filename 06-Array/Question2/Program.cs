using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for(int i=0;i<n;i++)
            {
                Console.Write("element - {0} : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for(int i=n-1;i>=0;i--)
            {
                Console.Write("{0} ",arr[i]);
            }
        }
    }
}

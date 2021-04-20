using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] arr = new int[10]; 
            Console.Write("Input 10 elements in the array :\n");  
            for(int i=0; i<10; i++)  
            {  
                Console.Write("element - {0} : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());  		
            }  
        
            Console.Write("\nElements in array are: ");  
            for(int i=0; i<10; i++)  
            {  
                Console.Write("{0}  ", arr[i]);  
            } 
        }
    }
}

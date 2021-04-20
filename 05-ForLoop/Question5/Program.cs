using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,ctr;	
            
            Console.Write("Input number of terms : ");
            ctr= Convert.ToInt32(Console.ReadLine());	
            for(i=1;i<=ctr;i++)
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n",i,i, (i*i*i));     
            }
        }
    }
}

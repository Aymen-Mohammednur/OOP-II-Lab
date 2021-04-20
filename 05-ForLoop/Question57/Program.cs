using System;

namespace Question57
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1 = ""; 
            int i,l;
			
			
            Console.Write("\n\n");
            Console.Write("Print a string in reverse order:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");				

            Console.Write("Input  A String : ");
            str = Console.ReadLine();

            l = str.Length-1;
            for (i=l;i>=0;i--)
            {

                str1 = str1 + str[i];
                

            }

            Console.WriteLine("The string in Reverse  Order Is : {0}", str1);
        
        }
    }
}

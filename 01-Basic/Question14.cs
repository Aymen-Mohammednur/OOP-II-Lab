using System;

namespace C_Sharp_Basic
{
    public class Question14
    {
        public static void ConvertTemp()
        {
            Console.Write("Enter the amount of celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());

            decimal kelvin = celsius + 273;
            decimal fah = (celsius * 9/5) + 32;
            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fah);
        }
    }
}
using System;

namespace C_Sharp_Basic
{
    public class Question30
    {
        public static void HexaToDecimal()
        {
            Console.Write("Input a hexadecimal number: ");
            string hexa = Console.ReadLine();
            int dec =  int.Parse(hexa, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("Hexadecimal number: "+hexa);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: "+dec);
        }
    }
}
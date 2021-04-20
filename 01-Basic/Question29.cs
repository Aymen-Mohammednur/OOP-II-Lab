using System;
using System.IO;

namespace C_Sharp_Basic
{
    public class Question29
    {
        public static void SizeOfFile()
        {
            FileInfo file = new FileInfo("ForQ29.txt");
            string size = file.Length.ToString();
            Console.WriteLine("Size of the file: {0}", size);
        }
    }
}
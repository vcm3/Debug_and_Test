using System;
using Vigenere.Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            VigenereCode v = new VigenereCode("ucu", 8);
            Console.WriteLine(v.Decrypt("ISVJED"));
            Console.WriteLine(v.Decrypt("HOFGWCTDKPY"));
            Console.WriteLine(v.Decrypt("JSFFOP"));
        }
    }
}

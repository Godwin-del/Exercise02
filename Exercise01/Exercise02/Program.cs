using Exercise01;
using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Enter a Number to convert to currency");
            string number = Console.ReadLine();
            number = class1.TranslateNumberToWords(number);
            Console.WriteLine(number);
        
            }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatimStringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // \t \n \" \\

            string speech = "He said \"something\"";
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course\nThis is a new line";

            Console.WriteLine(speech);
            Console.WriteLine(path);
            Console.WriteLine();

            // $ +
            // $"Your name is: {name}"
            // "Your name is: " + name

            path = @"C:\\Users\\CoffeeNCode\\Desktop\\C# Course";
            Console.WriteLine(path);

            path = @"C:\Users\CoffeeNCode\Desktop\C# Course\nCannot use (\n) while using the @ simpol ";
            Console.WriteLine(path);

            path = @"C:\Users\CoffeeNCode\Desktop\C# Course " + "\nThis is a new line";
            Console.WriteLine(path);

            string name = @"Hello, ""someone""";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Naser";
            int age = 29;

            Console.WriteLine("Your name is " + name + ", your age is " + age);
            Console.WriteLine("Your name is {0}, your age is {1}", name, age);
            Console.WriteLine($"Your name is {name}, your age is {age}");
            Console.WriteLine(string.Concat("Your name is ", name, ", your age is ", age));

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

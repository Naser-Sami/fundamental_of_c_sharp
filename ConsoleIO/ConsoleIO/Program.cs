using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name =  Console.ReadLine();
            Console.Write("How old are you? ");
            string ageInput = Console.ReadLine(); // or convert it direct 
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("Hello, your name is: " + name + " and your age is: " + int.Parse(ageInput));

            Console.WriteLine("Your age after adding 2 years is " + (int.Parse(ageInput) + 2));


            Console.ReadLine();
        }
    }
}

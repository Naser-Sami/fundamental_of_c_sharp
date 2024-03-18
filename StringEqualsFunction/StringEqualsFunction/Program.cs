using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEqualsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare)) // message == compare
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (!name.Equals("")) // name != ""
            {
                Console.WriteLine($"Your name is {name}");
            } else
            {
                Console.WriteLine("Invalid name input.");
            }

            // 
            //

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);

            // .Equals not only compare the values it's also compare the ( memory address location )
            if (message.Equals(newCompare)) 
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            Console.ReadLine();
        }
    }
}

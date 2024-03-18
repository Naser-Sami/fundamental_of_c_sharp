using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            Console.WriteLine();
            Console.Write("Enter second number: ");
            int num2 = 0;
            bool success = int.TryParse(Console.ReadLine(), out num2);

            if (success)
            {
                Console.WriteLine(num2);
            } else
            {
                Console.WriteLine("Faild to convert!");
            }*/

            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, out int numOutput))
                {
                    success = false;
                    Console.WriteLine(numOutput);
                } else
                {
                    Console.WriteLine("Faild to convert!");
                }
            }

            

            Console.ReadLine();
        }
    }
}

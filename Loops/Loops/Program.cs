using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("********************");

            for (int i = 1;i <= 10; i += 2) 
            {
                Console.WriteLine(i);
            }*/

            Console.Write("What do you want to print out? ");
            string msg = Console.ReadLine();

            Console.Write("How many times to do want to print " + msg + " ? ");
            int loopCount = Convert.ToInt32(Console.ReadLine());

            if (loopCount <= 0 )
            {
                Console.WriteLine("Please enter a value above 0");
            } else
            {
                for (int i = 1; i <= loopCount; i++)
                {
                    Console.WriteLine(i + "- " + msg);
                }
            }

            Console.ReadLine();
        }
    }
}

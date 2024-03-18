using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //     (variable); (condition);
            // for (int i = 0;    i < 10;    i++) {}

            // variable
            int i = 0;

            // condition
            while ( i < 10 )
            {
                i++;
                //Console.WriteLine(i);
                //i++;
            }


            // ------------------------------------------------

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            int acutualAnswer = Convert.ToInt32(Console.ReadLine());


        

            /*while ( answer != acutualAnswer )
            {
                Console.WriteLine("Close but it was wrong!");

                Console.WriteLine();
                Console.WriteLine("Enter your value: ");
                Console.Write("Value of " + numberA + " x " + numberB + ": ");
                acutualAnswer = Convert.ToInt32(Console.ReadLine());
            }*/

            //Console.WriteLine();
            //Console.WriteLine("Well done!");

            /*if (answer == acutualAnswer)
            {
                Console.WriteLine("Well done!");
            }*/


            // do while loop

            do
            {
                Console.WriteLine("Close but it was wrong!");

                Console.WriteLine();
                Console.WriteLine("Enter your value: ");
                Console.Write("Value of " + numberA + " x " + numberB + ": ");
                acutualAnswer = Convert.ToInt32(Console.ReadLine());
            } while ( answer != acutualAnswer );


            Console.WriteLine();
            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFizzBbuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 
             * Create a for loop from 1 to x ( 15 )
             * 
             *      - if the number divisible by three and five
             *          3 and 5 = FizzBuzz
             *      - if the number divisible by three     
             *          3 = Fizz
             *      - if the number divisible by five         
             *          5 = Buzz
             *          
             *      else = number
             * 
             */

            Console.Write("Enter a number: ");
            int number = 0;
            bool threeDiv = false;
            bool fiveDiv = false;

            bool isParsingSuccess = int.TryParse(Console.ReadLine(), out number);
            if (isParsingSuccess)
            {
                for (int i = 1; i <= number; i++)
                {

                    threeDiv = i % 3 == 0;
                    fiveDiv = i % 5 == 0;

                    if (threeDiv && fiveDiv)
                    {
                        Console.WriteLine(i + " FizzBuzz");
                    }
                    else if (threeDiv)
                    {
                        Console.WriteLine(i + " Fizz");
                    }
                    else if (fiveDiv)
                    {
                        Console.WriteLine(i + " Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            } else
            {
                Console.WriteLine("Enter a valid integer value");
            }


            Console.ReadLine();

        }
    }
}

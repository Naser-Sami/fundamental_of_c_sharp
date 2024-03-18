using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number for the table
            // Write for loop to print x times table

            bool playAgain = true;

            while (playAgain)
            {
                Console.Write("Enter a number: ");
                bool parseSuccess = int.TryParse(Console.ReadLine(), out int number);

                if (parseSuccess)
                {
                    if (number > 0)
                    {
                        for (int i = 1; i <= number; i++)
                        {
                            // Console.WriteLine("table count = " + (i + 1));
                            Console.WriteLine("{0} x {1} = {2}", i , number, i * number);
                        }
                    }
                    else if (number == 0)
                    {
                        Console.WriteLine("no tables");
                    }
                    else
                    {
                        Console.WriteLine("Negative values not allowed.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer value");
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to play again!  ( Type 'y' to play 'n' to exit ) ");
                if (Console.ReadLine() == "y")
                {
                    playAgain = true;
                } else
                {
                    playAgain = false;
                }
            }


            // Console.ReadLine();
        }
    }
}

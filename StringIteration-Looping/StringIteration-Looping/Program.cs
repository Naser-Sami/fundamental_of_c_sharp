using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringIteration_Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String iteration ( looping )
            string message = "C# is awesome";

            /*Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);
            Console.WriteLine(message[3]);*/

            for (int i = 0; i < message.Length; i++)
            {
                //Console.WriteLine(message[i]);
                Console.Write(message[i]);
                Thread.Sleep(250);  // 1000ms = 1sec
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));
            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'a')
                {
                    contains = true;
                }

                if (message[i].Equals("B"))
                {
                    
                }
            }

            Console.WriteLine(contains);
            Console.ReadLine();

        }
    }
}

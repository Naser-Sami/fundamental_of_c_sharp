using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 / 3 = 3r1
            // 3  * 3 = 9, 1 left over to get 10

            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum % secondNum);

            Console.ReadLine();
        }
    }
}

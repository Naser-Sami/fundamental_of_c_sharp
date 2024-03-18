using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;

            age++;
            age = age + 1;
            age += 1;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);

            string name = "Aba";
            name += " is Programming!";
            // name -= " is Programming!";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'h';
            Console.WriteLine(ch); // it will take the unicode value and add them togother

            int i = 0;
            Console.WriteLine(i++); // it's print i value which is 0 then it's added 1 for it's value
            Console.WriteLine(++i); // here the i is now equal to 1 and with adding ++ then print it. it's now 1+1 = 2

            Console.ReadLine();
        }
    }
}

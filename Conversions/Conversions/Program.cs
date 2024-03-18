using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine(age.GetType());


            string textBigNumber = "-9000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);
            Console.WriteLine(bigNumber.GetType());


            string textBigDecimal = "-55.20";
            double bigDecimal = Convert.ToDouble(textBigDecimal);
            Console.WriteLine(bigDecimal);
            Console.WriteLine(bigDecimal.GetType());


            string textPrecision = "-23.20";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);
            Console.WriteLine(precision.GetType());


            string textMoney = "40.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
            Console.WriteLine(money.GetType());


            Console.ReadLine();
        }
    }
}

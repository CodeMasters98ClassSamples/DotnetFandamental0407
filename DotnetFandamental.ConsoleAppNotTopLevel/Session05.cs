using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFandamental.ConsoleAppNotTopLevel
{
    internal class Session05
    {
        public static void main()
        {
            Console.WriteLine("First number:");
            string num1Str = Console.ReadLine() ?? "";
            int num1 = int.Parse(num1Str);

            Console.WriteLine("Second number:");
            string num2Str = Console.ReadLine() ?? "";
            int num2 = int.Parse(num2Str);

            int result = Sum(num1, num2);

            Console.WriteLine($"Num1 is : {num1} and num2 is : {num2} and result is : {result}");

        }

        static int Sum(int num1, int num2, int num3 = 0)
        {
            int result = num1 + num2 + num3;
            return result;
        }
    }
}

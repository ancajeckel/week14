using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add((decimal)2.5,3));
            Console.WriteLine(calc.Subtract((decimal)2.5, 3));
            Console.WriteLine(calc.Multiply((decimal)2.5, 3));
            Console.WriteLine(calc.Divide((decimal)2.5, 3));

            Console.ReadKey();
        }
    }
}

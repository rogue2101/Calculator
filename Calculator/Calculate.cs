using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDLL;

namespace CalculateNumbers
{
    internal class Calculate
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(10, 5));
            Console.WriteLine(calculator.Substract(10.5, 5));
            Console.WriteLine(calculator.Divide(10.5, 5));
            Console.WriteLine(calculator.Multiply(10.5, 5));
            Console.WriteLine(calculator.Add("10.5", "5"));
            Console.WriteLine(calculator.Add("abc", "def"));
            Console.ReadKey();
        }
    }
}

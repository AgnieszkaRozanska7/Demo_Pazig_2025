using CalculatorApp.Services;
using CalculatorApp.Services.Interfaces;
using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculate calculate = new Calculate();
            Console.WriteLine($"Wybik dodawania: {calculate.Add(10, 15)}");
            Console.WriteLine($"Wybik mnozenia: {calculate.Multiply(10, 15)}");
            Console.ReadLine();
        }
    }
}

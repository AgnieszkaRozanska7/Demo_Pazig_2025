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
            Console.WriteLine($"Wynik dodawania: {calculate.Add(10, 15)}");
            Console.WriteLine($"Wynik odejmowania: {calculate.Minus(10, 15)}");
            Console.WriteLine($"Wynik mnozenia: {calculate.Multiply(10, 15)}");
            Console.ReadLine();
        }
    }
}

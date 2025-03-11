using CalculatorApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Services
{
    public class Calculate : ICalculate
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Minus(double value1, double value2)
        {
            return value1 - value2; 
        }
    }
}

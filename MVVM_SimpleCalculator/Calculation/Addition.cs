using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_SimpleCalculator.Calculation
{
    public class Addition : ICalculable
    {
        public double? Calculate(double? firstValue, double? secondValue)
        {
            return firstValue + secondValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_SimpleCalculator.Calculation
{
    public interface ICalculable
    {
        double? Calculate(double? firstValue, double? secondValue);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_SimpleCalculator.Calculation
{
    public class Division : ICalculable
    {
        public double? Calculate(double? firstValue, double? secondValue)
        {
            try
            {
                if (secondValue == 0)
                {
                    throw new DivideByZeroException();
                }
                return firstValue / secondValue;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }
    }
}

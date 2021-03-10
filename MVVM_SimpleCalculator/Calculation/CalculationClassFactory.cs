using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_SimpleCalculator.Calculation
{
    public class CalculationClassFactory
    {
        public ICalculable GetOperationClass(string command)
        {
            ICalculable calculateClass = default(ICalculable);

            switch (command)
            {
                case "add" :
                    calculateClass = new Addition();
                    break;
                case "divide":
                    calculateClass = new Division();
                    break;
                case "multiply":
                    calculateClass = new Multiplication();
                    break;
                case "substract":
                    calculateClass = new Substraction();
                    break;
            }

            return calculateClass;
        }
    }
}

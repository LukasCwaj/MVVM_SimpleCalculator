using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_SimpleCalculator.Model
{
    public class Calculator
    {

        #region define of values
        private double? _firstValue;

        public double? FirstValue
        {
            get { return _firstValue; }
            set { _firstValue = value;}
        }

        private double? _secondValue;

        public double? SecondValue
        {
            get { return _secondValue; }
            set { _secondValue = value;}
        }

        private double? _result;

        public double? Result
        {
            get { return _result; }
            set { _result = value;}
        }
        #endregion
    }
}

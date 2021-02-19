using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_SimpleCalculator.Model
{
    public class Calculator: INotifyPropertyChanged
    {
        #region implement of interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged (double? prop)
        {
            string propString = prop.ToString();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propString));
        }
        #endregion

        #region define of values
        private double? _firstValue;

        public double? FirstValue
        {
            get { return _firstValue; }
            set { _firstValue = value; OnPropertyChanged(FirstValue); }
        }

        private double? _secondValue;

        public double? SecondValue
        {
            get { return _secondValue; }
            set { _secondValue = value; OnPropertyChanged(SecondValue); }
        }

        private double? _result;

        public double? Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged(Result); }
        }
        #endregion

        #region calculations
        public double? Addition (double? firstValue, double? secondValue)
        {
            return firstValue + secondValue;
        }

        public double? Substraction(double? firstValue, double? secondValue)
        {
            return firstValue - secondValue;
        }

        //use try catch to catch divide by zero exception, and show message with this exception
        public double? Division(double? firstValue, double? secondValue)
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

        public double? Multiplication(double? firstValue, double? secondValue)
        {
            return firstValue * secondValue;
        }

        #endregion 
    }
}

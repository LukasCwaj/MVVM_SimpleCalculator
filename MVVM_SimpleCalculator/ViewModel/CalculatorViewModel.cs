﻿using MVVM_SimpleCalculator.Command;
using MVVM_SimpleCalculator.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace MVVM_SimpleCalculator.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        #region implement of interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        #region set connection with Calculator
        private Calculator calculation;

        public Calculator Calculation
        {
            get { return calculation; }
            set { calculation = value; }
        }

        public CalculatorViewModel()
        {
            Calculation = new Calculator();
        }

        public double? Calculation1
        {
            get { return Calculation.FirstValue; }
            set { Calculation.FirstValue = value; NotifyPropertyChanged("Calculation1"); }
        }

        public double? Calculation2
        {
            get { return Calculation.SecondValue; }
            set { Calculation.SecondValue = value; NotifyPropertyChanged("Calculation2"); }
        }

        public double? Calculation3
        {
            get { return Calculation.Result; }
            set { Calculation.Result = value; NotifyPropertyChanged("Calculation3");}
        }
        #endregion

        #region command to execute
        private ICommand _AddCommand;
        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                {
                    _AddCommand = new RelayCommand(AddExecute, CanExecute);
                }
                return _AddCommand;
            }
        }

        private void AddExecute(object parameter)
        {
            Calculation3 = calculation.Addition(Calculation1, Calculation2);
            SendMessage();
        }

        private ICommand _SubstractCommand;
        public ICommand SubstractCommand
        {
            get
            {
                if (_SubstractCommand == null)
                {
                    _SubstractCommand = new RelayCommand(SubstractExecute, CanExecute);
                }
                return _SubstractCommand;
            }
        }

        private void SubstractExecute(object parameter)
        {
            Calculation3 = calculation.Substraction(Calculation1, Calculation2);
            SendMessage();
        }

        private ICommand _DivideCommand;
        public ICommand DivideCommand
        {
            get
            {
                if (_DivideCommand == null)
                {
                    _DivideCommand = new RelayCommand(DivideExecute, CanExecute);
                }
                return _DivideCommand;
            }
        }
        private void DivideExecute(object parameter)
        {
            try
            {
                Calculation3 = calculation.Division(Calculation1, Calculation2);
                SendMessage();
            }
            catch (Exception e)
            {
            }
        }

        private ICommand _MultiplyCommand;
        public ICommand MultiplyCommand
        {
            get
            {
                if (_MultiplyCommand == null)
                {
                    _MultiplyCommand = new RelayCommand(MultiplyExecute, CanExecute);
                }
                return _MultiplyCommand;
            }
        }
        private void MultiplyExecute(object parameter)
        {
            Calculation3 = calculation.Multiplication(Calculation1, Calculation2);
            SendMessage();
        }

        private ICommand _ClearWindowCommand;
        public ICommand ClearWindowCommand
        {
            get
            {
                if (_ClearWindowCommand == null)
                {
                    _ClearWindowCommand = new RelayCommand(ClearWindowExecute);
                }
                return _ClearWindowCommand;
            }
        }

        private void ClearWindowExecute(object parameter)
        {
            Calculation1 = null;
            Calculation2 = null;
            Calculation3 = null;
        }

        private bool CanExecute(object parameter)
        {
            if (calculation.FirstValue != null && calculation.SecondValue != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region message after execute comand
        public void SendMessage()
        {
            MessageBoxResult wantToContinue = MessageBox.Show("Would you like to continue?", 
                                                              "Caution", MessageBoxButton.YesNo);
            switch (wantToContinue)
            {
                case MessageBoxResult.Yes:
                    this.wantToContinue(true);
                    break;
                case MessageBoxResult.No:
                    this.wantToContinue(false);
                    break;
                default:
                    break;
            }
        }

        public void wantToContinue(bool wantContinue)
        {
            if (wantContinue)
            {
                Calculation1 = Calculation3;
                Calculation2 = null;
                Calculation3 = null;
            }
        }
        #endregion 
    }
}

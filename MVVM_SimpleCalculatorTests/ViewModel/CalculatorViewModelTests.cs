using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVVM_SimpleCalculator.ViewModel;
using MVVM_SimpleCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_SimpleCalculator.ViewModel.Tests
{
    [TestClass()]
    public class CalculatorViewModelTests
    {
        [TestMethod()]
        public void wantToContinueTest()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();

            viewModel.Calculation1 = 1;
            viewModel.Calculation2 = 2;
            viewModel.Calculation3 = 3;
            viewModel.wantToContinue(true);

            Assert.AreEqual(3, viewModel.Calculation1, "Can't move result to first value");
            Assert.IsNull(viewModel.Calculation2, "Second value is not null");
            Assert.IsNull(viewModel.Calculation3, "Result is not null");
        }
    }
}
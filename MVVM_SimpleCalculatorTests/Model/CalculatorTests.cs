using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVVM_SimpleCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_SimpleCalculator.Model.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            Calculator calculator = new Calculator();
            calculator.FirstValue = 1;
            calculator.SecondValue = 1;
            int expected = 2;

            for(int i=0; i<100;i++)
            {
                calculator.Result = calculator.Addition(calculator.FirstValue, calculator.SecondValue);
                Assert.AreEqual(expected, calculator.Result);
                Assert.IsNotNull(calculator.Result);
                calculator.FirstValue++;
                calculator.SecondValue++;
                expected += 2;
            }
           
        }

        [TestMethod()]
        public void SubstractionTest()
        {
            Calculator calculator = new Calculator();
            calculator.FirstValue = 100;
            calculator.SecondValue = 1;
            int expected = 99;

            for (int i = 0; i < 100; i++)
            {
                calculator.Result = calculator.Substraction(calculator.FirstValue, calculator.SecondValue);
                Assert.AreEqual(expected, calculator.Result);
                Assert.IsNotNull(calculator.Result);
                calculator.FirstValue--;
                expected -= 1;
            }
        }

        [TestMethod()]
        public void DivisionTest()
        {
            Calculator calculator = new Calculator();
            calculator.FirstValue = 100;
            calculator.SecondValue = 1;
            int expected = 100;

            for (int i = 0; i < 100; i++)
            {
                calculator.Result = calculator.Division(calculator.FirstValue, calculator.SecondValue);
                Assert.AreEqual(expected, calculator.Result);
                Assert.IsNotNull(calculator.Result);
                calculator.FirstValue += 100;
                calculator.SecondValue++;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest_DivideByZero()
        {
            Calculator calculator = new Calculator();
            calculator.FirstValue = 10;
            calculator.SecondValue = 0;

            calculator.Division(calculator.FirstValue, calculator.SecondValue);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            Calculator calculator = new Calculator();
            calculator.FirstValue = 100;
            calculator.SecondValue = 1;
            int expected = 100;

            for (int i = 0; i < 100; i++)
            {
                calculator.Result = calculator.Multiplication(calculator.FirstValue, calculator.SecondValue);
                Assert.AreEqual(expected, calculator.Result);
                Assert.IsNotNull(calculator.Result);
                calculator.SecondValue++;
                expected += 100;
            }
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void PerformOperation_Add_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            string operation = "add";
            double expected = 15;

            // Act
            double result = _calculator.PerformOperation(num1, num2, operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PerformOperation_Subtract_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            string operation = "subtract";
            double expected = 5;

            // Act
            double result = _calculator.PerformOperation(num1, num2, operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PerformOperation_Multiply_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            string operation = "multiply";
            double expected = 50;

            // Act
            double result = _calculator.PerformOperation(num1, num2, operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PerformOperation_Divide_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            string operation = "divide";
            double expected = 2;

            // Act
            double result = _calculator.PerformOperation(num1, num2, operation);

            // Assert
            Assert.AreEqual(expected, result);
        }
      
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void PerformOperation_DivideByZero_ThrowsException()
        {
            // Arrange
            double num1 = 10;
            double num2 = 0;
            string operation = "divide";

            // Act
            _calculator.PerformOperation(num1, num2, operation);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PerformOperation_InvalidOperation_ThrowsException()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            string operation = "invalid";

            // Act
            _calculator.PerformOperation(num1, num2, operation);
        }
    }
}
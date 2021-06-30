using Calculator.App;
using Calculator.Test.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Test
{
    public class CalculatorFactoryTest
    {
        private readonly CalculatorFactory calculatorFactory;
        public CalculatorFactoryTest()
        {
            calculatorFactory = new CalculatorFactory();
        }

        [Theory]
        [ClassData(typeof(CalculatorFactoryData))]
        public void CalculatorFactory_Operator_Tests(decimal expected, string OperatorSign,  decimal input1, decimal input2)
        {
            var response = calculatorFactory.Calculate(OperatorSign,input1, input2);
            Assert.Equal(expected, response);
        }
    }
}

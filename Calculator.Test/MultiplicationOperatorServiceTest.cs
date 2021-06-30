using Calculator.App.Operator;
using Calculator.Test.Data;
using Xunit;

namespace Calculator.Test
{
    public class MultiplicationOperatorServiceTest
    {

        private readonly MultiplicationOperatorService multiplicationOperatorService;
        public MultiplicationOperatorServiceTest()
        {
            multiplicationOperatorService = new MultiplicationOperatorService();
        }

        [Theory]
        [ClassData(typeof(MultiplicationOperatorData))]
        public void Multiplication_Operator_Tests(decimal expected, decimal input1, decimal input2)
        {
            var response = multiplicationOperatorService.Operate(input1, input2);
            Assert.Equal(expected, response);
        }
    }
}

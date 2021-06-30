using Calculator.App.Operator;
using Calculator.Test.Data;
using Xunit;

namespace Calculator.Test
{
    public class SubstractionOperatorServiceTest
    {
        private readonly SubstractionOperatorService substractionOperatorService;
        public SubstractionOperatorServiceTest()
        {
            substractionOperatorService = new SubstractionOperatorService();
        }

        [Theory]
        [ClassData(typeof(SubstractionOperatorData))]
        public void Substraction_Operator_Tests(decimal expected, decimal input1, decimal input2)
        {
            var response = substractionOperatorService.Operate(input1, input2);
            Assert.Equal(expected, response);
        }
    }
}

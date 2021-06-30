using Calculator.App.Operator;
using Xunit;

namespace Calculator.Test
{
    public class AdditionOperatorServiceTest
    {
        private readonly AdditionOperatorService additionOperatorService;
        public AdditionOperatorServiceTest()
        {
            additionOperatorService = new AdditionOperatorService();
        }

        [Theory]
        [ClassData(typeof(AdditionOperatorData))]
        public void Addition_Operator_Tests(decimal expected, decimal input1, decimal input2)
        {
            var response = additionOperatorService.Operate(input1, input2);
            Assert.Equal(expected, response);
        }
    }
}

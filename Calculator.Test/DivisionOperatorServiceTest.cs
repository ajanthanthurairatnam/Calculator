using Calculator.App.Operator;
using Calculator.Test.Data;
using Xunit;

namespace Calculator.Test
{
    public class DivisionOperatorServiceTest
    {
        private readonly DivisionOperatorService divisionOperatorService;
        public DivisionOperatorServiceTest()
        {
            divisionOperatorService = new DivisionOperatorService();
        }

        [Theory]
        [ClassData(typeof(DivisionOperatorData))]
        public void Division_Operator_Tests(decimal expected, decimal input1, decimal input2)
        {
            var response = divisionOperatorService.Operate(input1, input2);
            Assert.Equal(expected, response);
        }
    }
}

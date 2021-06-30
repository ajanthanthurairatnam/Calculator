namespace Calculator.App.Operator
{
    public class AdditionOperatorService : IOperatorService
    {
        public decimal Operate(decimal inputOne, decimal inputTwo)
        {
            return inputOne + inputTwo;
        }
    }
}

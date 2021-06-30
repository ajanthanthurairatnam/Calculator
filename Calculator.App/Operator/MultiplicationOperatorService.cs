namespace Calculator.App.Operator
{
    public class MultiplicationOperatorService : IOperatorService
    {
        public decimal Operate(decimal inputOne, decimal inputTwo)
        {
            return inputOne * inputTwo;
        }
    }
}

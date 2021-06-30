namespace Calculator.App.Operator
{
    public class SubstractionOperatorService : IOperatorService
    {
        public decimal Operate(decimal inputOne, decimal inputTwo)
        {
            return inputOne - inputTwo;
        }
    }
}

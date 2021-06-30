namespace Calculator.App.Operator
{
    public class DivisionOperatorService : IOperatorService
    {
        public decimal Operate(decimal inputOne, decimal inputTwo)
        {
            return inputOne / inputTwo;
        }
    }
}

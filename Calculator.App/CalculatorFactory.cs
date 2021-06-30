using System;

namespace Calculator.App
{
    public class CalculatorFactory
    {
        public decimal Calculate(string operatorSign, decimal inputOne, decimal inputTwo)
        {
            string OperatorType = "";
            switch (operatorSign)
            {
                case "+":
                     OperatorType = "AdditionOperatorService";
                    break;
                case "-":
                    OperatorType = "SubstractionOperatorService";
                    break;
                case "*":
                    OperatorType = "MultiplicationOperatorService";
                    break;
                case "/":
                    OperatorType = "DivisionOperatorService";
                    break;
                default:
                    return decimal.MinValue;
            }

            Type t = Type.GetType($"Calculator.App.Operator.{OperatorType}");
            IOperatorService operatorService = (IOperatorService)Activator.CreateInstance(t);
            return operatorService.Operate(inputOne, inputTwo);
        }
    }
}

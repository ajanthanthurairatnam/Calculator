using System.Collections;
using System.Collections.Generic;

namespace Calculator.Test.Data
{
    class CalculatorFactoryData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 5, "+", 2, 3 };
            yield return new object[] { 2, "/", 10, 5 };
            yield return new object[] { 20, "*", 4, 5 };
            yield return new object[] { 40, "-", 45, 5 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

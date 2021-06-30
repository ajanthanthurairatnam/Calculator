using System.Collections;
using System.Collections.Generic;

namespace Calculator.Test.Data
{
    public class MultiplicationOperatorData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 50, 10, 5 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

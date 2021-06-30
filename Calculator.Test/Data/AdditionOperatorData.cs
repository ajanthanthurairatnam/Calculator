using System.Collections;
using System.Collections.Generic;

namespace Calculator.Test
{
    public class AdditionOperatorData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 2, 1, 1 };
            yield return new object[] { 5, 2, 3 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using System.Collections;
using System.Collections.Generic;

namespace Calculator.Test.Data
{
    public class SubstractionOperatorData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 5, 10, 5 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

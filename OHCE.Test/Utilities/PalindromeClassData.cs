using OHCE.Langues;
using System.Collections;

namespace OHCE.Test.utilities
{
    public class PalindromeClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new LangueFrançaise(), "laval" };
            yield return new object[] { new LangueAnglaise(), "radar" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
using OHCE.Langues;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities
{
    internal class BonjourClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new LangueFrançaise() };
            yield return new object[] { new LangueAnglaise() };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
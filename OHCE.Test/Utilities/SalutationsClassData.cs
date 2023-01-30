using OHCE.Langues;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities
{
    internal class SalutationsPeriodeClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new LangueFrançaise(), new PeriodeFrançais().matin };
            yield return new object[] { new LangueFrançaise(), new PeriodeFrançais().apresMidi };
            yield return new object[] { new LangueFrançaise(), new PeriodeFrançais().soiree };
            yield return new object[] { new LangueFrançaise(), new PeriodeFrançais().nuit };
            yield return new object[] { new LangueFrançaise(), new PeriodeAnglais().matin };
            yield return new object[] { new LangueFrançaise(), new PeriodeAnglais().apresMidi };
            yield return new object[] { new LangueFrançaise(), new PeriodeAnglais().soiree };
            yield return new object[] { new LangueFrançaise(), new PeriodeAnglais().nuit };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
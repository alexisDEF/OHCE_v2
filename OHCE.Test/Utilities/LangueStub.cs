using OHCE.Langues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities
{
    public class LangueStub : ILangue
    {
        public string BienDit => new LangueFrançais().BienDit;
    }
}
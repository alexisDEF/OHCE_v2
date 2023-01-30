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
        private ILangue langue => new LangueFrançais();
        public string BienDit => langue.BienDit;
        public string Bonjour => langue.Bonjour;
    }
}
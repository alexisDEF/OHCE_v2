using OHCE.Langues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class OHCEBuilder
    {

        private ILangue langue;

        private string periode;

        public OHCEBuilder withLangue(ILangue langue)
        {
            this.langue = langue;

            return this;
        }

        public OHCEBuilder withPeriode(string periode)
        {
            this.periode = periode;
            return this;
        }

        public Ohce build()
        {
            return new Ohce(this.langue, this.periode);
        }
    }
}
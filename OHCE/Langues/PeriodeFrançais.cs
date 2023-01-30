using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class PeriodeFrançais : IPeriode
    {
        public string matin => "matin";

        public string apresMidi => "après-midi";
        public string soiree => "soiréee";

        public string nuit => "nuit";
    }
}
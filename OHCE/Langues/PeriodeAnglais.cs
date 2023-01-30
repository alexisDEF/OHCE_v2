using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class PeriodeAnglais : IPeriode
    {
        public string matin => "morning";

        public string apresMidi => "afternoon";

        public string soiree => "evening";

        public string nuit => "night";
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public interface IPeriode
    {
        string matin { get; }
        string apresMidi { get; }
        string soiree { get; }
        string nuit { get; }

    }
}
using OHCE.Langues;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class LangueSystème
    {
        public ILangue RecupLangue()
        {
            string systemLanguage = CultureInfo.CurrentCulture.Name;

            switch (systemLanguage)
            {
                case "fr-FR":
                    return new LangueFrançais();

                case "en-EN":
                    return new LangueAnglais();

                default: throw new ArgumentException("Langue non implémentée");
            }
        }
    }
}
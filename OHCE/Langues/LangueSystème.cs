using OHCE.Langues;
using System.Globalization;

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
                    return new LangueFrançaise();

                case "en-EN":
                    return new LangueAnglaise();

                default: throw new ArgumentException("Langue non implémentée");
            }
        }
    }
}
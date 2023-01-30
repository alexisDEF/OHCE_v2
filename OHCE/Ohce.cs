using OHCE.Langues;
using System;
using System.Text;

namespace OHCE
{
    public class Ohce
    {
        private readonly ILangue _langue;
        //public string _periode;
        //private readonly MomentDeLaJournée _momentDeLaJournée;

        public Ohce(ILangue langue)
        {
            _langue = langue;
            //_periode = periode;
            //_momentDeLaJournée = momentDeLaJournée;
        }

        /*public string Miroir(string chaîne)
        {
            var miroir = new string(chaîne.Reverse().ToArray());
            var estUnPalindrome = miroir.Equals(chaîne);
            return string.Empty;
            return _langue.Saluer(_momentDeLaJournée)
                   + miroir
                   + (estUnPalindrome ? _langue.BienDit : string.Empty);
        }*/

        public string Traitement(string mot)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Bonjour");
            stringBuilder.Append(_langue.Bonjour);

            var miroir = new string(mot.Reverse().ToArray());
            stringBuilder.Append(miroir);
            if (miroir == mot)
            {
                stringBuilder.Append(_langue.BienDit);
            }
            stringBuilder.Append("Au revoir");
            return stringBuilder.ToString();
        }

        public string DireBonjour()
        {
            return (_langue.Bonjour).Trim();
        }

        public string Miroir(string mot)
        {
            var stringBuilder = new StringBuilder();

            var miroir = new string(mot.Reverse().ToArray());
            stringBuilder.Append(miroir);

            if (miroir == mot)
            {
                stringBuilder.Append(" " + _langue.BienDit);
            }

            return stringBuilder.ToString();
        }

        public string DireAuRevoir()
        {
            return (_langue.AuRevoir).Trim();
        }
    }
}
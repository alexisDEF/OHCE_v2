using OHCE.Langues;

namespace OHCE
{
    public class Ohce
    {
        private readonly ILangue _langue;
        //private readonly MomentDeLaJournée _momentDeLaJournée;

        public Ohce(ILangue langue)
        {
            _langue = langue;
            //_momentDeLaJournée = momentDeLaJournée;
        }

        public string Miroir(string chaîne)
        {
            var miroir = new string(chaîne.Reverse().ToArray());
            var estUnPalindrome = miroir.Equals(chaîne);
            return string.Empty;
            /**return _langue.Saluer(_momentDeLaJournée)
                   + miroir
                   + (estUnPalindrome ? _langue.BienDit : string.Empty);*/
        }
    }
}
namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {

        /// <inheritdoc />
        public string BienDit => Expressions.Anglais.BienDit;
        public string Bonjour => "Hello";
        public string AuRevoir => "Goodbye";
        public string Saisie => "Please enter a string of characters";

    }
}

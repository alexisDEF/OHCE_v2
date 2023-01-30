using OHCE.Langues;
using OHCE.Test.utilities;
using OHCE.Test.Utilities;

namespace OHCE.Test
{
    public class OHCETest
    {
        [Theory]
        [InlineData("toto")]
        [InlineData("test")]
        public void TestMiroir(string chaîne)
        {
            // QUAND on envoie une chaîne à OHCE
            var resultat = new Ohce(new LangueStub()).Traitement("laval");

            //ALORS on obtient son miroir
            Assert.Contains("laval", resultat);
        }

        public static IEnumerable<object[]> CasTestBonjour => new []
        {
            new object[]
            {
                new LangueAnglaise(), 
                MomentDeLaJournée.Indéterminé, 
                Expressions.Anglais.Salutation
            },
            new object[]
            {
                new LangueAnglaise(),
                MomentDeLaJournée.Matin,
                Expressions.Anglais.GoodMorning
            },
            new object[]
            {
                new LangueFrançaise(), 
                MomentDeLaJournée.Indéterminé, 
                Expressions.Français.Salutation
            },
        };

        [Theory]
        [MemberData(nameof(CasTestBonjour))]
        public void TestBonjour()
        {
            //QUAND on saisit une chaîne
            var resultat = new Ohce(new LangueStub()).Traitement("test de chaine");

            //ALORS « Bonjour » est envoyé avant toute réponse
            Assert.StartsWith("Bonjour", resultat);
        }

        public static IEnumerable<object[]> CasTestAuRevoir => new[]
        {
            new object[] { new LangueFrançaise(), Expressions.Français.Acquittance },
            new object[] { new LangueAnglaise(), Expressions.Anglais.Acquittance }
        };

        [Theory]
        [MemberData(nameof(CasTestAuRevoir))]
        public void TestAuRevoir()
        {
            //QUAND on saisit une chaîne
            var resultat = new Ohce(new LangueStub()).Traitement("test de chaine");

            //ALORS « Bonjour » est envoyé avant toute réponse
            Assert.EndsWith("Au revoir", resultat);
        }

        public static IEnumerable<object[]> CasTestBienDit => new[]
        {
            new object[] { new LangueFrançaise(), Expressions.Français.BienDit },
            new object[] { new LangueAnglaise(), Expressions.Anglais.BienDit }
        };

        [Theory(DisplayName = "QUAND on envoie un palindrome ALORS on obtient celui-ci ET 'Bien dit !' est ajouté")]
        [ClassData(typeof(PalindromeClassData))]
        public void TestPalindromeLangue(ILangue langue)
        {

            //QUAND on envoie un mot
            var resultat = new Ohce(langue).Traitement(palindrome);
            //ALORS on obtient celui-ci
            Assert.Contains(palindrome, resultat);
            var indexOfPalindrome = resultat.IndexOf(palindrome, StringComparison.Ordinal);
            var endOfPalindrome = indexOfPalindrome + palindrome.Length;
            resultat = resultat[endOfPalindrome..];

            //ET 'Bien dit !' est ajouté
            Assert.Contains(langue.BienDit, resultat);
        }

        [Theory]
        [MemberData(nameof(CasTestBienDit))]
        public void TestNonPalindrome(ILangue langue, string bienDit)
        {
            // ETANT DONNE un utilisateur parlant <langue>
            var ohce = new OhceBuilder()
                .AyantPourLangue(langue)
                .Build();

            // QUAND on envoie une chaîne qui n'est palindrome à OHCE
            const string chaîne = "test";
            var résultat = ohce.Miroir(chaîne);
            
            // ALORS 'Bien dit' en <langue> n'est pas renvoyé
            Assert.DoesNotContain(bienDit, résultat);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on saisit une chaîne ALORS <bonjour> de cette langue est envoyé avant tout")]
        [ClassData(typeof(BonjourClassData))]
        public void TestBonjourLangue(ILangue langue)
        {

            //QUAND on saisit une chaîne
            var resultat = new Ohce(langue).Traitement("test de chaine");

            //ALORS <bonjour> de cette langue est envoyé avant tout
            Assert.StartsWith(langue.Bonjour, resultat);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on saisit une chaîne ALORS <auRevoir> dans cette langue est envoyé en dernier")]
        [ClassData(typeof(BonjourClassData))]
        public void TestAuRevoirLangue(ILangue langue)
        {
            //QUAND on saisit une chaîne
            var resultat = new Ohce(new LangueStub()).Traitement("test de chaine");

            //ALORS « Bonjour » est envoyé avant toute réponse
            Assert.EndsWith(langue.AuRevoir, resultat);
        }
    }
}
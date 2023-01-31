using OHCE;
using OHCE.Langues;
using System.Globalization;

ILangue langueSys = new LangueSystème().RecupLangue();
string periodeSys = new PeriodeSystème().RecupererPeriode(langueSys);
string chaine;
var ohce = new OHCEBuilder().withLangue(langueSys).withPeriode(periodeSys).build();

Console.WriteLine(ohce.DireBonjour());

Console.WriteLine("");

do
{
    Console.Write(langueSys.Saisie + " : ");
    chaine = Console.ReadLine();

    if (chaine != "")
    {
        Console.WriteLine("");
        Console.WriteLine(ohce.Miroir(chaine));
        Console.WriteLine("");
    }

} while (chaine != "");

Console.WriteLine("");
Console.WriteLine(ohce.DireAuRevoir());
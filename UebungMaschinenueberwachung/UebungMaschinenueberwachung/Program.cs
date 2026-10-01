using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UebungMaschinenueberwachung
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            StartseitenEingabe Hauptmenü = new StartseitenEingabe();

            AnsichtStartseite DasErsteWasNutzerSieht = new AnsichtStartseite();

            TemperaturKonsolenEingabe TemperaturenMaschine = new TemperaturKonsolenEingabe();
            List<int> temperaturen = new List<int>();

            Grenzwert GrenzwertAusgabe = new Grenzwert();

            Statistik StatistikAnzeigen = new Statistik();

            TemperaturSichern NixMerken = new TemperaturSichern();


            if(System.IO.File.Exists("Temperaturen.txt"))
            {
                var dateiTemperatur = System.IO.File.ReadAllLines("Temperaturen.txt");
                foreach (var line in dateiTemperatur)
                {
                    temperaturen.Add(int.Parse(line));
                }
            }

            int anzahlWarnungen = 0;

            while (true)
            {
                DasErsteWasNutzerSieht.ZeigeStartseite();


                int zahl = int.Parse(Console.ReadLine());


                Hauptmenü.Auswertung(zahl, temperaturen, ref anzahlWarnungen, TemperaturenMaschine, StatistikAnzeigen, GrenzwertAusgabe, NixMerken);

            }

        }

    }
}

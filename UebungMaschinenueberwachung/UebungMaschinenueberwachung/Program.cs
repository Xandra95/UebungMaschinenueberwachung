using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UebungMaschinenueberwachung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Startseite MaschinenüberwachungHauptmenü = new Startseite();

            StartseiteAuswertung MaschinenHauptmenüAuswertung = new StartseiteAuswertung();

            TemperaturwertUser MaschinenTemperatur = new TemperaturwertUser();
            List<int> temperaturen = new List<int>();

            Grenzwert MaschinenGrenzwert = new Grenzwert(); //Mit Statistik in eine Klasse

            Statistik MaschinenStatistik = new Statistik();

            DatenSpeicherung TemperaturSpeichern = new DatenSpeicherung();

            // User Klasse Erstellen

            if(System.IO.File.Exists("Temperaturen.txt")) //Das in die Klasse DatenSpeicherung
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
                MaschinenüberwachungHauptmenü.MaschinenStartseiteMethode();


                int zahl = int.Parse(Console.ReadLine());


                MaschinenHauptmenüAuswertung.Auswertung(zahl, temperaturen, ref anzahlWarnungen, MaschinenTemperatur, MaschinenStatistik, MaschinenGrenzwert, TemperaturSpeichern);

            }

        }

       

    }
}

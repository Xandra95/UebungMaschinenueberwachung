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

            TemperaturAuswertung MaschinenAuswertung = new TemperaturAuswertung();

            DatenSpeicherung TemperaturSpeichern = new DatenSpeicherung();

            UserAusgabe MaschinenAuswertungUserAusgabe = new UserAusgabe();
           

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


                MaschinenHauptmenüAuswertung.Auswertung(zahl, temperaturen, ref anzahlWarnungen, MaschinenTemperatur,  MaschinenAuswertung,TemperaturSpeichern);

            }

        }

       

    }
}

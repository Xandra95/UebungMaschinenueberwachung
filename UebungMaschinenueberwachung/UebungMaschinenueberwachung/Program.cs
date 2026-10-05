using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UebungMaschinenueberwachung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Startseite Startseite = new Startseite();

            StartseiteAuswertung StartseiteAuswertung = new StartseiteAuswertung();

            TemperaturwertUser TemperaturwertUser = new TemperaturwertUser();
            List<TemperaturInfo> temperaturen = new ();

            TemperaturAuswertung TemperaturAuswertung = new TemperaturAuswertung();

            DatenSpeicherung DatenSpeicherung = new DatenSpeicherung();

            
           

            if(System.IO.File.Exists("Temperaturen.txt")) //Das in die Klasse DatenSpeicherung
            {
                var dateiTemperatur = System.IO.File.ReadAllLines("Temperaturen.txt");
                foreach (var line in dateiTemperatur)
                {
                    TemperaturInfo temperaturInfo = new TemperaturInfo();
                    temperaturInfo.Temperatur = int.Parse(line);
                    temperaturen.Add(temperaturInfo);
                }
            }

         

            while (true)
            {
                Startseite.MaschinenStartseiteMethode();


                int zahl = int.Parse(Console.ReadLine());


                StartseiteAuswertung.Auswertung(zahl, temperaturen,  TemperaturwertUser,  TemperaturAuswertung,DatenSpeicherung);

            }

        }

       

    }
}

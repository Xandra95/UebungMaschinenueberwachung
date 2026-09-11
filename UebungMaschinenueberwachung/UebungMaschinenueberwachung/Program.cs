using System.Reflection;
using System.Runtime.CompilerServices;

namespace UebungMaschinenueberwachung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Es fehlt noch die Schleife für die wiederholte Anzeige der Startseite, bis der Benutzer das Programm beendet.
            ZeigeStartseite();

            // Die Methode selbst gehhört nicht in die Main-Methode, sondern sollte außerhalb definiert werden.
            static void ZeigeStartseite()
            {
                // Interessante Lösung: Wie bist du auf die Idee gekommen, die Startseite so zu gestalten?
                List<string> start = new List<string>
                {
                    "1 - Temperatur erfassen",
                    "2 - Statisik erfassen",
                    "3 - Grenzwerte prüfen",
                    "0 - Programm beenden"
                };


                foreach (var starts in start)
                {
                    Console.WriteLine(starts);
                }            


                int zahl = Convert.ToInt32(Console.ReadLine());


                StartEingabe(zahl);

            }

            List<int> temperaturen = new List<int>();

            // Das sollte ebenfalls in eine eigene Methode ausgelagert werden, um die Main-Methode übersichtlicher zu gestalten.
            while(true)
            {
                Console.Write("Bitte weitere Temperauren angeben oder Drücken Sie s um zurück zur Startseite zu gelangen. ");
                string eingabe = Console.ReadLine();
                // Interessante Lösung: Wie bist du auf die Idee gekommen, die Schleife so zu gestalten?
                if (eingabe == "s")
                {
                    break;
                }
                int temperatur = Convert.ToInt32(eingabe);
                temperaturen.Add(temperatur);
            }

        }

        static void StartEingabe(int zahl)
        {
// Hier solltest du dann die entsprechende Aktion basierend auf der Eingabe ausführen.
            // Am besten wäre es, wenn du diese Logik ebenfalls in separate Methoden auslagerst.
            if (zahl == 0)
            {
                Environment.Exit(0);
            }
            else if (zahl == 2)
            {
                Console.WriteLine("Hier ist Ihre Statistik zu den Temperaturwerten ");
            }
            else if (zahl == 3)
            {
                Console.WriteLine("Grenzwerte wurden geprüft: ");
            }
            else if (zahl == 1)
            {
                Console.WriteLine("Bitte Temperaturwerte eingeben");
                int erfassung = Convert.ToInt32(Console.ReadLine());

            }
        }


        
    }
}
       
        
            


        
    

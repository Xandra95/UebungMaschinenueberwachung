using System.Reflection;
using System.Runtime.CompilerServices;

namespace UebungMaschinenueberwachung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZeigeStartseite();

            static void ZeigeStartseite()
            {
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


            while(true)
            {
                Console.Write("Bitte weitere Temperauren angeben oder Drücken Sie s um zurück zur Startseite zu gelangen. ");
                string eingabe = Console.ReadLine();

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

            if (zahl == 1)
            {
                Console.WriteLine("Bitte Temperaturwerte eingeben");
                int erfassung = Convert.ToInt32(Console.ReadLine());

            }
            else if (zahl == 2)
            {
                Console.WriteLine("Hier ist Ihre Statistik zu den Temperaturwerten ");
            }
            else if (zahl == 3)
            {
                Console.WriteLine("Grenzwerte wurden geprüft: ");
            }
            else
            {

            }
        }


        
    }
}
       
        
            


        
    

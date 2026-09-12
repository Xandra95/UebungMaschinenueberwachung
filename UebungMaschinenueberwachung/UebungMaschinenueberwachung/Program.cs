using System.Reflection;
using System.Runtime.CompilerServices;

namespace UebungMaschinenueberwachung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> temperaturen = new List<int>();

            while (true)
            {
                ZeigeStartseite();


                int zahl = Convert.ToInt32(Console.ReadLine());


                StartEingabe(zahl, temperaturen);

            }

        }


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
        }

        static void StartEingabe(int zahl, List<int> temperaturen)
        {

            if (zahl == 1)
            {

                while (true)
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

            if (zahl == 0)
            {
                Environment.Exit(0);
            }
            else if (zahl == 2)
            {
                // ÄNDERN !
            }
            else if (zahl == 3)
            {
                Console.WriteLine("Grenzwerte wurden geprüft: ");
            }

        }
            
        static void StatistikAnzeigen(List<int> temperaturen)
        {
            double durchschnitt = temperaturen.Average();
            int minimum = temperaturen.Min();
            int maximum = temperaturen.Max();

            Console.WriteLine("Hier ist ihre Statistik zu den Temperaturwerten: ");
            Console.WriteLine("Durchschnitt: " + durchschnitt);
            Console.WriteLine("Minimum: " + minimum);
            Console.WriteLine("Maximum: " + maximum);
        }

        
    }
}
       
        
            


        
    

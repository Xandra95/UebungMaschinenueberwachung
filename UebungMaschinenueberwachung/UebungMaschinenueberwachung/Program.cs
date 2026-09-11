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
                List<string> ZeigeStartseite = new List<string>
                {
                    "1 - Temperatur erfassen",
                    "2 - Statisik erfassen",
                    "3 - Grenzwerte prüfen",
                    "0 - Programm beenden"
                };


                foreach (var erstes in ZeigeStartseite)
                {
                    Console.WriteLine(erstes);
                }

                int temperatur = 1;
                int statistik = 2;
                int grenzwert = 3;
                int beenden = 0;

                int eingegebeneZahl = Convert.ToInt32(Console.ReadLine());

                StartEingabe(eingegebeneZahl);

            }

        }

        static void StartEingabe(int eingegebeneZahl)
        {

            if (eingegebeneZahl == 1)
            {
                Console.WriteLine("Bitte Temperaturwerte eingeben");
                int erfassung = Convert.ToInt32(Console.ReadLine());

            }
            else if (eingegebeneZahl == 2)
            {
                Console.WriteLine("Hier ist Ihre Statistik zu den Temperaturwerten ");
            }
            else if (eingegebeneZahl == 3)
            {
                Console.WriteLine("Grenzwerte wurden geprüft: ");
            }
            else
            {

            }
        }


        
    }
}
       
        
            


        
    

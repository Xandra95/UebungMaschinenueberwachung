using System.Reflection;
using System.Runtime.CompilerServices;

namespace UebungMaschinenueberwachung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZeigeStartseite();
        }
        static void ZeigeStartseite()
        {
            List<string> ZeigeStartseite = new List<string>
            {
                "1 - Temperatur erfassen",
                "2 - Statisik erfassen",
                "3 - Grenzwerte prüfen",
                "0 - Programm beenden"
            };

            foreach(var erstes in ZeigeStartseite)
            {
                Console.WriteLine(erstes);
            }

            StartEingabe();

            int temperatur = 1;
            int statisik = 2;
            int grenzwert = 3;
            int beenden = 0;

            static void StartEingabe()
            {
                Console.ReadLine();
            }

        }
        
            


        
    }
}

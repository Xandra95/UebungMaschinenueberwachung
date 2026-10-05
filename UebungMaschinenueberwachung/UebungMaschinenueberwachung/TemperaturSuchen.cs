using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UebungMaschinenueberwachung
{
    public class TemperaturSuchen
    {
        public void TemperaturSuchfunktion(List<TemperaturInfo> temperaturInfos)
        {

            int temperaturSuchen;
            bool sucheBeenden = false;

            do
            {
                string sucheingabe = Console.ReadLine();
                int.TryParse(sucheingabe, out temperaturSuchen);
                if (sucheingabe == "s")
                {
                    sucheBeenden = true;
                }
                else
                {
                    var TemperaturSuchen = temperaturInfos.Where(temp => temp.Temperatur == temperaturSuchen).ToList();
                    
                }

            } while (sucheBeenden);

        }
    }
}

using UebungMaschinenueberwachung;

public class TemperaturwertUser 
{

    

    public int Temperaturen(List<TemperaturInfo>temperaturen) //Kein Void -> Mit Rückgabewert (return)
    {

        UserAusgabe UserAusgabe = new UserAusgabe();

        int anzahlWarnungen = 0;

        while (true)
        {
            UserAusgabe.UserAusgabeTempErfassen();
            string eingabe = Console.ReadLine();

            if (eingabe == "s")
            {
                UserAusgabe.UserAusgabeTempErfassen();
                break;
            }

            int temperatur = Convert.ToInt32(eingabe);

            if (temperatur > 120 || temperatur < 0)
            {
                UserAusgabe.UngültigeEingabeUser();
            }
            else
            {
                TemperaturInfo temperaturInfo = new TemperaturInfo();
                temperaturInfo.Temperatur = temperatur;
                temperaturen.Add(temperaturInfo);

                if (temperatur > 80)
                {
                    anzahlWarnungen++;
                }

                if (temperatur > 90)
                {
                    UserAusgabe.KritischUserInteraktion(temperatur);
                }
            }

        }
        return anzahlWarnungen;
    }
  
}
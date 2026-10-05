public class TemperaturwertUser 
{

    

    public void Temperaturen(List<int>temperaturen, ref int anzahlWarnungen) //Kein Void
    {

        UserAusgabe UserEingabeTemperaturWrite = new UserAusgabe();
        

        while (true)
        {
           
            string eingabe = Console.ReadLine();

            if (eingabe == "s")
            {
                UserEingabeTemperaturWrite.ZahlOderSUserInteraktion();
                break;
            }

            int temperatur = Convert.ToInt32(eingabe);

            if (temperatur > 120 || temperatur < 0)
            {
                UserEingabeTemperaturWrite.UngültigeEingabeUserInteraktion();
            }
            else
            {
                temperaturen.Add(temperatur);

                if (temperatur > 80)
                {
                    anzahlWarnungen++;
                }

                if (temperatur > 90)
                {
                    UserEingabeTemperaturWrite.KritischUserInteraktion(temperatur);
                }
            }

        }
    }
  
}
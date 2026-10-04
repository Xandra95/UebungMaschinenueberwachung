public class StartseiteAuswertung
{
    public void Auswertung(int zahl, List<int>temperaturen, ref int anzahlWarnungen, TemperaturwertUser TemperaturenMaschine,UserAusgabe StatistikUserAusgabe, UserAusgabe GrenzwertUserAusgabe, DatenSpeicherung TemperaturenSpeichern )
    {
        

        if (zahl == 1)
        {
            TemperaturenMaschine.Temperaturen(temperaturen,ref anzahlWarnungen);
        }
        else if (zahl == 2)
        {
            StatistikUserAusgabe.StatistikAusgabe(temperaturen);
        }
        else if (zahl == 3)
        {
            GrenzwertUserAusgabe.GrenzwertPruefung(temperaturen, );
        }
        else if (zahl == 4) 
        {
            TemperaturenSpeichern.TemperaturenSpeichern(temperaturen);
        }
        else
        {
            Environment.Exit(0);
        }
        
    }
}
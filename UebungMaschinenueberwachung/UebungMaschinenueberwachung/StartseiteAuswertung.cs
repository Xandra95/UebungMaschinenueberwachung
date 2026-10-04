public class StartseiteAuswertung
{
    public void Auswertung(int zahl, List<int>temperaturen, ref int anzahlWarnungen, TemperaturwertUser TemperaturenMaschine,TemperaturAuswertung MaschinenAuswertung, DatenSpeicherung TemperaturenSpeichern )
    {
        

        if (zahl == 1)
        {
            TemperaturenMaschine.Temperaturen(temperaturen,ref anzahlWarnungen);
        }
        else if (zahl == 2)
        {
            MaschinenAuswertung.StatistikBerechnung(temperaturen);
        }
        else if (zahl == 3)
        {
            MaschinenAuswertung.GrenzwertePruefung(temperaturen);
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
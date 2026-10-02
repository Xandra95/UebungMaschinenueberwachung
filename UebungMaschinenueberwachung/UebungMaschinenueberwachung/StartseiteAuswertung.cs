public class StartseiteAuswertung
{
    public void Auswertung(int zahl, List<int>temperaturen, ref int anzahlWarnungen, Zahlenwert TemperaturenMaschine,Statistik StatistikAnzeigen, Grenzwert Grenzwertausgabe, DatenSpeicherung NixMerken )
    {
        

        if (zahl == 1)
        {
            TemperaturenMaschine.Temperaturen(temperaturen,ref anzahlWarnungen);
        }
        else if (zahl == 2)
        {
            StatistikAnzeigen.StatistikBerechnung(temperaturen);
        }
        else if (zahl == 3)
        {
            Grenzwertausgabe.GrenzwertePruefung(temperaturen);
        }
        else if (zahl == 4) 
        {
            NixMerken.TemperaturenSpeichern(temperaturen);
        }
        else
        {
            Environment.Exit(0);
        }
        
    }
}
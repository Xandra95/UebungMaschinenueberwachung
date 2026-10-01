public class StartseitenEingabe
{
    public void Auswertung(int zahl, List<int>temperaturen, ref int anzahlWarnungen, TemperaturKonsolenEingabe TemperaturenMaschine,Statistik StatistikAnzeigen, Grenzwert Grenzwertausgabe, TemperaturSichern NixMerken )
    {
        

        if (zahl == 1)
        {
            TemperaturenMaschine.Temperaturen(temperaturen,ref anzahlWarnungen);
        }
        else if (zahl == 2)
        {
            StatistikAnzeigen.StatistikAnzeigen(temperaturen);
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
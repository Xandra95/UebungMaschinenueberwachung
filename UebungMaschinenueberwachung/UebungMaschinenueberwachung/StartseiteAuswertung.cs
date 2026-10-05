using UebungMaschinenueberwachung;

public class StartseiteAuswertung
{
    public void Auswertung(int zahl, List<TemperaturInfo> temperaturen, TemperaturwertUser TemperaturenMaschine, TemperaturAuswertung MaschinenAuswertung, DatenSpeicherung TemperaturenSpeichern)
    {
        UserAusgabe userAusgabe = new UserAusgabe();

        if (zahl == 1)  // Hier eine switch Verzweigung, Enum
        {
            int anzahlWarnungen = TemperaturenMaschine.Temperaturen(temperaturen);
            userAusgabe.WarnungAusgabe(anzahlWarnungen);
        }
        else if (zahl == 2)
        {
            int min = MaschinenAuswertung.GetMin(temperaturen);
            int max = MaschinenAuswertung.GetMax(temperaturen);
            double durchschnitt = MaschinenAuswertung.GetDurchschnitt(temperaturen);

            userAusgabe.StatistikUserAusgabe(durchschnitt, min, max);
        }
        else if (zahl == 3)
        {
            List<TemperaturInfo> info = MaschinenAuswertung.GrenzwertePruefung(temperaturen);
            foreach (var temperatur in info)
            {
                userAusgabe.GrenzwertUserAusgabe(temperatur.Temperatur, temperatur.Kategorie);
            }
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
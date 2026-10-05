using UebungMaschinenueberwachung;

public class StartseiteAuswertung
{
    public void Auswertung(int zahl, List<TemperaturInfo> temperaturen, TemperaturwertUser TemperaturenMaschine, TemperaturAuswertung MaschinenAuswertung, DatenSpeicherung TemperaturenSpeichern)
    {
        UserAusgabe userAusgabe = new UserAusgabe();

        switch (zahl)  // Hier eine switch Verzweigung, Enum
        {
            case 1:
                {
                    int anzahlWarnungen = TemperaturenMaschine.Temperaturen(temperaturen);
                    userAusgabe.WarnungAusgabe(anzahlWarnungen);
                    break;
                }

            case 2:
                {
                    int min = MaschinenAuswertung.GetMin(temperaturen);
                    int max = MaschinenAuswertung.GetMax(temperaturen);
                    double durchschnitt = MaschinenAuswertung.GetDurchschnitt(temperaturen);

                    userAusgabe.StatistikUserAusgabe(durchschnitt, min, max);
                    break;
                }

            case 3:
                {
                    List<TemperaturInfo> info = MaschinenAuswertung.GrenzwertePruefung(temperaturen);
                    foreach (var temperatur in info)
                    {
                        userAusgabe.GrenzwertUserAusgabe(temperatur.Temperatur, temperatur.Kategorie);
                    }

                    break;
                }

            case 4:
                TemperaturenSpeichern.TemperaturenSpeichern(temperaturen);
                break;
            default:
                Environment.Exit(0);
                break;
        }

    }
}
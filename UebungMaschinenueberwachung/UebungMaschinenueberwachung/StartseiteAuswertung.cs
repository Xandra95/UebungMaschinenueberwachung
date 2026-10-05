using UebungMaschinenueberwachung;

public class StartseiteAuswertung
{
    public static void Auswertung(int zahl, List<TemperaturInfo> temperaturen, TemperaturwertUser TemperaturenMaschine, TemperaturAuswertung TemperaturAuswertung, DatenSpeicherung TemperaturenSpeichern, TemperaturSuchen temperaturSuchen)
    {
        UserAusgabe userAusgabe = new UserAusgabe();

        switch (zahl)  
        {
            case 1:
                {
                    int anzahlWarnungen = TemperaturenMaschine.Temperaturen(temperaturen);
                    userAusgabe.WarnungAusgabe(anzahlWarnungen);
                    break;
                }

            case 2:
                {
                    int min = TemperaturAuswertung.GetMin(temperaturen);
                    int max = TemperaturAuswertung.GetMax(temperaturen);
                    double durchschnitt = TemperaturAuswertung.GetDurchschnitt(temperaturen);

                    userAusgabe.StatistikUserAusgabe(durchschnitt, min, max);
                    break;
                }

            case 3:
                {
                    List<TemperaturInfo> info = TemperaturAuswertung.GrenzwertePruefung(temperaturen);
                    foreach (var temperatur in info)
                    {
                        userAusgabe.GrenzwertUserAusgabe(temperatur.Temperatur, temperatur.Kategorie);
                    }

                    break;
                }

            case 4:
                TemperaturenSpeichern.TemperaturenSpeichern(temperaturen);
                break;

            case 5:
                temperaturSuchen.TemperaturSuchfunktion(temperaturen);
                userAusgabe.SuchfunktionUserAusgabe(temperaturen.Count);
                break;

            default:
                Environment.Exit(0);
                break;
        }

    }
}
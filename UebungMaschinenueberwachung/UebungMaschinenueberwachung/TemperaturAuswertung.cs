public class TemperaturAuswertung
{
    public void StatistikBerechnung(List<int> temperaturen)
    {
        double durchschnitt = temperaturen.Average();
        int minimum = temperaturen.Min();
        int maximum = temperaturen.Max();

        UserAusgabe StatistikMaschineUser = new UserAusgabe();
        StatistikMaschineUser.StatistikAusgabe(durchschnitt, minimum, maximum);
    }


    public void GrenzwertePruefung(List<int> temperaturen)
    {
        UserAusgabe GrenzwertMaschineUser = new UserAusgabe();

        foreach (var temperatur in temperaturen)
        {
            if (temperatur < 50)
            {
                GrenzwertMaschineUser.GrenzwertAusgabe(temperatur, "Kühl");
            }
            else if (temperatur < 80)
            {
                GrenzwertMaschineUser.GrenzwertAusgabe(temperatur, "Normal");
            }
            else
            {
                GrenzwertMaschineUser.GrenzwertAusgabe(temperatur, "WARNUNG!");
            }


        }
    }
}
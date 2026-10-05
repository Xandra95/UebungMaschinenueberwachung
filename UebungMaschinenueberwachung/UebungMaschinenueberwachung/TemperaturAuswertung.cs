public class TemperaturAuswertung
{
    public void StatistikBerechnung(List<int> temperaturen)
    {
        double durchschnitt = temperaturen.Average();
        int minimum = temperaturen.Min();
        int maximum = temperaturen.Max();

        UserAusgabe StatistikMaschineUser = new UserAusgabe();
        StatistikMaschineUser.StatistikUserAusgabe(durchschnitt, minimum, maximum);
    }


    public void GrenzwertePruefung(List<int> temperaturen)
    {
        UserAusgabe GrenzwertMaschineUser = new UserAusgabe();

        foreach (var temperatur in temperaturen)
        {
            if (temperatur < 50)
            {
                GrenzwertMaschineUser.GrenzwertUserAusgabe(temperatur, "Kühl");
            }
            else if (temperatur < 80)
            {
                GrenzwertMaschineUser.GrenzwertUserAusgabe(temperatur, "Normal");
            }
            else
            {
                GrenzwertMaschineUser.GrenzwertUserAusgabe(temperatur, "WARNUNG!");
            }


        }
    }
}
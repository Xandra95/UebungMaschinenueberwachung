using UebungMaschinenueberwachung;

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

    public int GetMin(List<TemperaturInfo> temperaturen)
    {
        return temperaturen.Min(x => x.Temperatur);
    }

    public int GetMax(List<TemperaturInfo>temperaturen)
    {
        return temperaturen.Max(x => x.Temperatur);
    }

    public double GetDurchschnitt(List<TemperaturInfo>temperaturen)
    {
        return temperaturen.Average(x => x.Temperatur);
    }

    public List<TemperaturInfo> GrenzwertePruefung(List<TemperaturInfo> temperaturen)
    {


        for (int i = 0; i < temperaturen.Count; i++)
        {
            
            if (temperaturen[i].Temperatur < 50)
            {
                temperaturen[i].Kategorie = "Kühl";
            }
            else if (temperaturen[i].Temperatur < 80)
            {
                temperaturen[i].Kategorie = "Normal";
            }
            else
            {
                temperaturen[i].Kategorie = "WARNUNG!";

            }

        }
        return temperaturen;
    }
}
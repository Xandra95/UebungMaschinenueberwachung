public class  AnsichtStartseite
{
    public void ZeigeStartseite()
    {
        List<string> start = new List<string>
                {
                    "1 - Temperatur erfassen",
                    "2 - Statisik erfassen",
                    "3 - Grenzwerte prüfen",
                    "4 - Temperaturen speichern",
                    "0 - Programm beenden"
                };

        foreach (var starts in start)
        {
            Console.WriteLine(starts);
        }
    }
}
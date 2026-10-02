public class DatenSpeicherung
{
    public void TemperaturenSpeichern(List<int> temperaturen)
    {
        System.IO.File.WriteAllLines("Temperaturen.txt", temperaturen.Select(x => x.ToString()));
    }
}
using UebungMaschinenueberwachung;

public class DatenSpeicherung
{
    public void TemperaturenSpeichern(List<TemperaturInfo> temperaturen)
    {
        System.IO.File.WriteAllLines("Temperaturen.txt", temperaturen.Select(x => x.Temperatur.ToString()));
    }
}
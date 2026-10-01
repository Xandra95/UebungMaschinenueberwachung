public class Grenzwert
{
    public void GrenzwertePruefung(List<int> temperaturen)
    {
        foreach (var temperatur in temperaturen)
        {
            if (temperatur < 50)
            {
                Console.WriteLine(temperatur + " Grad Celsius --> Kühl");
            }
            else if (temperatur < 80)
            {
                Console.WriteLine(temperatur + " Grad Celsius --> Normal");
            }
            else
            {
                Console.WriteLine(temperatur + " Grad Celsius --> WARNUNG!");
            }


        }
    }
}
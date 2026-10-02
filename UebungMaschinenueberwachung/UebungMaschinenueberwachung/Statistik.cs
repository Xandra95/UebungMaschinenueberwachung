public class Statistik   // Kein ConsoleWriteLine / Kein Void. Außerdem mit Grenzwert in eine Klasse
{
    public void StatistikBerechnung(List<int> temperaturen)
    {
        double durchschnitt = temperaturen.Average();
        int minimum = temperaturen.Min();
        int maximum = temperaturen.Max();



        Console.WriteLine("Hier ist Ihre Statistik zu den Temperaturwerten: ");
        Console.WriteLine($"Durchschnitt:  {durchschnitt}");
        Console.WriteLine($"Minimum:  {minimum}");
        Console.WriteLine($"Maximum: {maximum}");
    }
}
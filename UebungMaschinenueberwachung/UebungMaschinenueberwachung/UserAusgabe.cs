public class UserAusgabe
{
    public void StatistikAusgabe (double durchschnitt, int minimum, int maximum)
    {
        Console.WriteLine("Hier ist Ihre Statistik zu den Temperaturwerten: ");
        Console.WriteLine($"Durchschnitt:  {durchschnitt}");
        Console.WriteLine($"Minimum:  {minimum}");
        Console.WriteLine($"Maximum: {maximum}");
    }

    public void GrenzwertAusgabe(int temperatur, string grenzstatus)
    {
        Console.WriteLine($"{temperatur} Grad Celsius ---->  {grenzstatus}");
    }
}
public class UserAusgabe
{
    public void WriteLineFarbig(string text, ConsoleColor textFarbe, ConsoleColor hintergrundFarbe)
    {
        Console.ForegroundColor = textFarbe;
        Console.BackgroundColor = hintergrundFarbe;

        Console.WriteLine(text);
        Console.ResetColor();
    }

    public void StatistikUserAusgabe (double durchschnitt, int minimum, int maximum)
    {
        Console.WriteLine("Hier ist Ihre Statistik zu den Temperaturwerten: ");
        Console.WriteLine($"Durchschnitt:  {durchschnitt}");
        Console.WriteLine($"Minimum:  {minimum}");
        Console.WriteLine($"Maximum: {maximum}");
    }

    public void GrenzwertUserAusgabe(int temperatur, string grenzstatus)
    {
        Console.WriteLine($"{temperatur} Grad Celsius ---->  {grenzstatus}");
    }

    public void ZahlOderSUserInteraktion()
    {
        Console.Write("Bitte Temperaturwert eingeben oder Drücken Sie s um zurück zur Startseite zu gelangen. ");
    }

    public void UngültigeEingabeUserInteraktion()
    {
        WriteLineFarbig("Fehler: Ungültige Eingabe.", ConsoleColor.Yellow, ConsoleColor.DarkGray);
    }

    public void KritischUserInteraktion(int temperatur)
    {
        WriteLineFarbig(temperatur + " Grad Celsius ---- KRITISCH Maschine SOFORT prüfen! ----", ConsoleColor.White, ConsoleColor.DarkRed);
    }
        

}
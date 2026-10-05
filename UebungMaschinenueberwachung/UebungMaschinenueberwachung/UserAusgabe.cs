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
        Console.WriteLine();
        Console.WriteLine($"Durchschnitt:  {durchschnitt}");
        Console.WriteLine($"Minimum:  {minimum}");
        Console.WriteLine($"Maximum: {maximum}");
        Console.WriteLine();
    }

    public void GrenzwertUserAusgabe(int temperatur, string grenzstatus)
    {
        Console.WriteLine();
        Console.WriteLine($"{temperatur} Grad Celsius ---->  {grenzstatus}");
    }

    public void UserAusgabeTempErfassen()
    {
        Console.WriteLine();
        WriteLineFarbig("Bitte Temperaturwert eingeben oder Drücken Sie s um zurück zur Startseite zu gelangen.", ConsoleColor.Black, ConsoleColor.White);
    }

    public void UngültigeEingabeUser()
    {
        Console.WriteLine();
        WriteLineFarbig("Fehler: Ungültige Eingabe.", ConsoleColor.Yellow, ConsoleColor.DarkGray);
    }
    
    public void KritischUserInteraktion(int temperatur)
    {
        Console.WriteLine();
        WriteLineFarbig(temperatur + " Grad Celsius ---- KRITISCH Maschine SOFORT prüfen! ----", ConsoleColor.White, ConsoleColor.DarkRed);
        
    }

    internal void WarnungAusgabe(int anzahlWarnungen)
    {
        Console.WriteLine();
        WriteLineFarbig($"Es wurden {anzahlWarnungen} Warnungen festgestellt", ConsoleColor.DarkRed, ConsoleColor.White);
        Console.WriteLine();
    }
}
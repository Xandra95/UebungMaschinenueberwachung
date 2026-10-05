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
        WriteLineFarbig("Hier ist Ihre Statistik zu den Temperaturwerten: ",ConsoleColor.Blue,ConsoleColor.Black);
        Console.WriteLine();
        Console.WriteLine($"Durchschnitt:  {durchschnitt}");
        Console.WriteLine($"Minimum:  {minimum}");
        Console.WriteLine($"Maximum: {maximum}");
        Console.WriteLine();
    }

    public void GrenzwertUserAusgabe(int temperatur, string grenzstatus)
    {
        Console.WriteLine($"{temperatur} Grad Celsius ---->  {grenzstatus}");
        Console.WriteLine("-------------------------------------");
    }

    public void UserAusgabeTempErfassen()
    {
        WriteLineFarbig("Bitte Temperaturwert eingeben oder Drücken Sie s um zurück zur Startseite zu gelangen.", ConsoleColor.DarkCyan, ConsoleColor.Black);
        Console.WriteLine("-----------------------------------------------------------------------------------");
    }

    public void UngültigeEingabeUser()
    {
        
        WriteLineFarbig("Fehler: Ungültige Eingabe.", ConsoleColor.Yellow, ConsoleColor.DarkGray);
        Console.WriteLine("-----------------------------------------------------------------------------------");
    }
    
    public void KritischUserInteraktion(int temperatur)
    {
        
        WriteLineFarbig(temperatur + " Grad Celsius ---- KRITISCH Maschine SOFORT prüfen! ----", ConsoleColor.White, ConsoleColor.DarkRed);
        Console.WriteLine("------------------------------------------------------------------------------------");
    }

    internal void WarnungAusgabe(int anzahlWarnungen)
    {
        WriteLineFarbig($"Es wurden {anzahlWarnungen} Warnungen festgestellt", ConsoleColor.DarkRed, ConsoleColor.White);
        Console.WriteLine("------------------------------------------------------------------------------------");
    }
}
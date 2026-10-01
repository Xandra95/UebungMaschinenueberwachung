public class TemperaturKonsolenEingabe
{

    public void WriteLineFarbig(string text, ConsoleColor textFarbe, ConsoleColor hintergrundFarbe)
    {
        Console.ForegroundColor = textFarbe;
        Console.BackgroundColor = hintergrundFarbe;

        Console.WriteLine(text);
        Console.ResetColor();
    }

    public void Temperaturen(List<int>temperaturen, ref int anzahlWarnungen)
    {
        while (true)
        {
            Console.Write("Bitte Temperatur angeben oder Drücken Sie s um zurück zur Startseite zu gelangen. ");
            string eingabe = Console.ReadLine();

            if (eingabe == "s")
            {
                break;
            }

            int temperatur = Convert.ToInt32(eingabe);

            if (temperatur > 120 || temperatur < 0)
            {
                WriteLineFarbig("Fehler: Ungültige Eingabe.",ConsoleColor.Yellow,ConsoleColor.DarkGray);
            }
            else
            {
                temperaturen.Add(temperatur);

                if (temperatur > 80)
                {
                    anzahlWarnungen++;
                }

                if (temperatur > 90)
                {
                    WriteLineFarbig(temperatur + " Grad Celsius ---- KRITISCH Maschine SOFORT prüfen! ----",ConsoleColor.Red, ConsoleColor.Gray);
                }
            }

        }
    }
  
}
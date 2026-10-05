public class  Startseite  
{
    public void MaschinenStartseiteMethode()
    {
        
        UserAusgabe UserAusgabeStartseite = new();
        

        List<string> start = new List<string>
                {
                    "---MASCHINENÜBERWACHUNG---",
                    "                       ",
                    "1 <- Temperatur erfassen",
                    "2 <- Statisik erfassen",
                    "3 <- Grenzwerte prüfen",
                    "4 <- Temperaturen speichern",
                    "5 <- Temperatur suchen",
                    "0 <- Programm beenden",
                    ""
                };

        foreach (var starts in start)
        {
            UserAusgabeStartseite.WriteLineFarbig(starts,ConsoleColor.Cyan,ConsoleColor.Black);
            
        }
    }
}
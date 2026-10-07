namespace KursPortal.Models
{
    public class Kurs 
    {
        public int ID { get; set; }
        public string? KursName { get; set; } 
        public string? Dozent { get; set; } 
        public int AnzahlTeilnehmer { get; set; }
        public int DauerInTagen { get; set; } 
        public string? Inhalt { get; set; }
        public string? Beschreibung { get; set; }
        public List<string> Lernziele { get; set; } = new() { };



    }
}

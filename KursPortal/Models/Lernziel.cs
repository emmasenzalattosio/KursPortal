namespace KursPortal.Models
{
    public class Lernziel
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int KursID { get; set; }
        public Kurs Kurs { get; set; }
    }
}

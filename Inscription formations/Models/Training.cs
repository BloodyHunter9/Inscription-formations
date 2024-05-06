namespace Inscription_formations.Models
{
    public class Training
    {
        public Training(string subject, int duration, DateTime startDate, DateTime endDate, string trainer, string room)
        {
            Subject = subject;
            Duration = duration;
            StartDate = startDate;
            EndDate = endDate;
            Trainer = trainer;
            Room = room;
        }

        public int Id { get; set; }
        public string Subject { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Trainer { get; set; }
        public string Room { get; set; }
    }
}

namespace Inscription_formations.Models
{
    public class Enrollment
    {
        public Enrollment(int trainingId, int studentId)
        {
            TrainingId = trainingId;
            StudentId = studentId;
        }

        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int StudentId { get; set; }
        public Training Training { get; set; }
        public Student Student { get; set; }
    }
}

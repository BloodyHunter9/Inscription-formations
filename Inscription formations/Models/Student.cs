namespace Inscription_formations.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }
}

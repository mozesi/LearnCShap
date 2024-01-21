namespace LearnCSharp.Models
{

    public enum Ranks { Adjunct, Insturctor, AssistantProfessor, AssociateProfessor}
    public class Instructor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Ranks Rank { get; set; }
        public DateTime HiringDate { get; set; }

    }
}

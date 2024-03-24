using System.ComponentModel.DataAnnotations;

namespace LearnCSharp.Models
{

    public enum Ranks { Adjunct, Insturctor, [Display(Name = "Assistant Professor")] AssistantProfessor, [Display(Name = "Associate Professor")] AssociateProfessor }
    public class Instructor
    {
        public int Id { get; set; }

        [Display(Name ="First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        public Ranks Rank { get; set; }

        [Display(Name = "Hiring Date")]

        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [Display(Name = "Is Tenured")]
        public Boolean isTenured {  get; set; }

    }
}

namespace LearnCSharp.Models
{
    public enum Major { CS, IT, MATH, OTHER }
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}

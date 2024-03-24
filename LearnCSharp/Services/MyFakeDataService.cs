using LearnCSharp.Models;

namespace LearnCSharp.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Instructor> Instructors { get; }

        public MyFakeDataService() { 
            Instructors = new List<Instructor> {
                new Instructor() {Id = 100,
                    FirstName = "Maegan", LastName = "Borer",
                    isTenured=false, HiringDate=DateTime.Parse("2018-08-15"),
                    Rank = Ranks.AssistantProfessor},
                new Instructor() {Id = 200,
                    FirstName = "Antonietta ", LastName = "Emmerich",
                    isTenured=true, HiringDate=DateTime.Parse("2022-08-15"),
                    Rank = Ranks.AssociateProfessor},
            }; 
        
        }

        
    }
}

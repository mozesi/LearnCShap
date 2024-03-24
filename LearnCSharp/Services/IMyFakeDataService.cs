using LearnCSharp.Models;

namespace LearnCSharp.Services
{
    public interface IMyFakeDataService
    {
        List<Instructor> Instructors { get; }
    }
}

using Entities.Models;

namespace Business.Abstracts;

public interface IInstructorService
{
    Task<Instructor?> GetByIdAsync(Guid id);
    Task<IList<Instructor>> GetAllAsync();
    Task<IList<Instructor>> GetByFullNameAsync(string firstName, string lastName);
    Task<IList<Instructor>> GetAllWithCoursesAsync();
    Task<Instructor> AddAsync(Instructor instructor);
    Task<Instructor> UpdateAsync(Instructor instructor);
    Task DeleteByIdAsync(Guid id);
}

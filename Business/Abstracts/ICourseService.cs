using Entities.Models;

namespace Business.Abstracts;

public interface ICourseService
{
    Task<Course?> GetByIdAsync(Guid id);
    Task<IList<Course>> GetAllAsync();
    Task<IList<Course>> GetAllWithCategoryAsync();
    Task<IList<Course>> GetAllWithInstructorAsync();
    Task<Course> AddAsync(Course course);
    Task<Course> UpdateAsync(Course course);
    Task DeleteByIdAsync(Guid id);
}

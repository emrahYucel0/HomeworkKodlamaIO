using Entities.Models;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<Category?> GetByIdAsync(Guid id);
    Task<IList<Category>> GetAllAsync();
    Task<IList<Category>> GetAllWithCoursesAsync();
    Task<Category> AddAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task DeleteByIdAsync(Guid id);
}
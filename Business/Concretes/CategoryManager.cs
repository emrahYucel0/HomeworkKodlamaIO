using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    public readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Category> AddAsync(Category category)
    {
        return await _categoryRepository.AddAsync(category);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var category = await _categoryRepository.GetAsync(c => c.Id == id);
        await _categoryRepository.DeleteAsync(category);
    }

    public async Task<IList<Category>> GetAllAsync()
    {
        var result = await _categoryRepository.GetAllAsync();
        return result.ToList();
    }

    public async Task<IList<Category>> GetAllWithCoursesAsync()
    {
        var result = await _categoryRepository.GetAllAsync(include: category => category.Include(c => c.Courses));
        return result.ToList();
    }

    public async Task<Category?> GetByIdAsync(Guid id)
    {
        return await _categoryRepository.GetAsync(c => c.Id == id);
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        return await _categoryRepository.UpdateAsync(category);
    }
}
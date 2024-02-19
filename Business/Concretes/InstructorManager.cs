using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorRepository _instructorRepository;
    public InstructorManager(IInstructorRepository instructorRepository)
    {
        _instructorRepository = instructorRepository;
    }
    public async Task<Instructor> AddAsync(Instructor instructor)
    {
        return await _instructorRepository.AddAsync(instructor);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var result = await _instructorRepository.GetAsync(i=>i.Id == id);
        await _instructorRepository.DeleteAsync(result);
    }

    public async Task<IList<Instructor>> GetAllAsync()
    {
        var result = await _instructorRepository.GetAllAsync();
        return result.ToList();
    }

    public async Task<IList<Instructor>> GetAllWithCoursesAsync()
    {
        var result = await _instructorRepository.GetAllAsync(include: instructor=>instructor.Include(i=>i.Courses));
        return result.ToList();
    }

    public async Task<IList<Instructor>> GetByFullNameAsync(string firstName, string lastName)
    {
        var instructors = await _instructorRepository.GetAllAsync(include: instructor => instructor.Include(i => i.Courses));
        var filteredInstructors = instructors
            .Where(i => i.FirstName == firstName && i.LastName == lastName)
            .ToList();
        return filteredInstructors;
    }

    public async Task<Instructor?> GetByIdAsync(Guid id)
    {
        return await _instructorRepository.GetAsync(i=>i.Id == id);
    }

    public async Task<Instructor> UpdateAsync(Instructor instructor)
    {
        return await _instructorRepository.UpdateAsync(instructor);
    }
}

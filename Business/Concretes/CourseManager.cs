using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    public readonly ICourseRepository _courseRepository;

    public CourseManager(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<Course> AddAsync(Course course)
    {
        return await _courseRepository.AddAsync(course);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var course = await _courseRepository.GetAsync(c=>c.Id == id);
        await _courseRepository.DeleteAsync(course);
    }

    public async Task<IList<Course>> GetAllAsync()
    {
        var result = await _courseRepository.GetAllAsync();
        return result.ToList();
    }

    public async Task<IList<Course>> GetAllWithCategoryAsync()
    {
        var result = await _courseRepository.GetAllAsync(include: course => course.Include(c => c.Category));
        return result.ToList();
    }

    public async Task<IList<Course>> GetAllWithInstructorAsync()
    {
        var result = await _courseRepository.GetAllAsync(include: course => course.Include(c => c.Instructor));
        return result.ToList();
    }

    public async Task<Course?> GetByIdAsync(Guid id)
    {
        return await _courseRepository.GetAsync(c=>c.Id == id);
    }

    public async Task<Course> UpdateAsync(Course course)
    {
        return await _courseRepository.UpdateAsync(course);
    }
}

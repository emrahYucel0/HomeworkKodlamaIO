using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Models;

namespace DataAccess.Concretes;

public class CourseRepository : Repository<Course>,ICourseRepository
{
    public CourseRepository(BusinessDbContext context) : base(context)
    {
    }
}

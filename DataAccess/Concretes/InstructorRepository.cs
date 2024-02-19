using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Models;

namespace DataAccess.Concretes;

public class InstructorRepository : Repository<Instructor>,IInstructorRepository
{
    public InstructorRepository(BusinessDbContext context) : base(context)
    {
    }
}

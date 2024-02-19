using Core.Repository;
using Entities.Models;

namespace DataAccess.Abstracts;

public interface ICourseRepository:IAsyncRepository<Course>
{
}

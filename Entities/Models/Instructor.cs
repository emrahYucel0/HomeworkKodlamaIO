using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models;

public class Instructor:Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string NationalIdentity { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
    public Instructor()
    {
        Courses = new HashSet<Course>();
    }
}

using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models;

public class Category:Entity<Guid>
{
    public string Name { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
    public Category()
    {
        Courses = new HashSet<Course>();
    }


}

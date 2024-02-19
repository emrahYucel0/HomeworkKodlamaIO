using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models;

public class Course:Entity<Guid>
{
    public Guid CategoryId { get; set; }
    public Guid InstructorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public short TotalBar { get; set; }
    public virtual Category Category { get; set; }
    public virtual Instructor Instructor { get; set; }

}

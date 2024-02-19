using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Contexts;

public class BusinessDbContext:DbContext
{
    protected IConfiguration Configuration;
    public BusinessDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Configuration.GetValue<string>("ConnectionStrings:Production");
        optionsBuilder.UseSqlServer(connectionString);
    }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Course> Courses {  get; set; }
    public DbSet<Category> Categories { get; set; }
}

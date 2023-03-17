using First_MVC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace First_MVC_Project.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
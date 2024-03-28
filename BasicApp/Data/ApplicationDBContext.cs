using BasicApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicApp.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}

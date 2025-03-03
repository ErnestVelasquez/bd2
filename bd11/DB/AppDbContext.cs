using bd11.Models;
using Microsoft.EntityFrameworkCore;

namespace bd11.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}

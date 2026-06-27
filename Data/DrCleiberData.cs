using DrCleiberSistema.Models;
using Microsoft.EntityFrameworkCore;

namespace DrCleiberSistema.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<PacienteModel>  Pacientes {get; set;}

    }
}

using Microsoft.EntityFrameworkCore;

namespace AsistenteCargaAcademica.Data
{
    public class AppDbContext : DbContext
    {
        // Define las tablas como DbSet<>
        /*public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Materia> Materias { get; set; }*/

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer("Server=TU_SERVIDOR;Database=AsistenteDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
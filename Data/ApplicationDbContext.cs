using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POWApp.Models;

namespace POWApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // importante

            // 👇 Datos semilla para la tabla Curso
            modelBuilder.Entity<Curso>().HasData(
                new Curso { Id = 1, Nombre = "C# Básico", Descripcion = "Aprende los fundamentos de C#" },
                new Curso { Id = 2, Nombre = "ASP.NET MVC", Descripcion = "Desarrollo de aplicaciones web con ASP.NET" },
                new Curso { Id = 3, Nombre = "SQL Server", Descripcion = "Consulta y diseño de bases de datos" }
            );
        }
    }
}

using ApresentacaoVisitas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApresentacaoVisitas.DB.Data
{
    public class VisitasContext : DbContext
    {
        public DbSet<Visitante> Visitantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visitante>().ToTable("Visitantes");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Visitas;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}

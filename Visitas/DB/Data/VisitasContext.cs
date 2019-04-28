using ApresentacaoVisitas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApresentacaoVisitas.DB.Data
{
    public class VisitasContext : DbContext
    {
        public VisitasContext(DbContextOptions<VisitasContext> options) : base(options)
        {
        }

        public DbSet<Visitante> Visitantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visitante>().ToTable("Visitantes");
        }
    }
}

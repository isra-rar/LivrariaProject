using LivrariaProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaProject.Data
{
    public class LivrariaProjectContext : DbContext
    {
        public LivrariaProjectContext(DbContextOptions<LivrariaProjectContext> options) 
            : base(options)
        {
        }


        public DbSet<Livro> Livro { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Marca> Marca { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().Property(l => l.Preco).HasColumnType("decimal(5,2)");
            base.OnModelCreating(modelBuilder);
        }
    }
}

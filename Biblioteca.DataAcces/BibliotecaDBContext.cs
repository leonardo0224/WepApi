using Biblioteca.DataAcces.Contracts;
using Biblioteca.DataAcces.Contracts.Entities;
using Biblioteca.DataAcces.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces
{
    public class BibliotecaDBContext : DbContext, IBibliotecaDBContext
    {
        public DbSet<AutorEntity> Autores { get; set; }
        public DbSet<CategoriaEntity> Categorias { get; set; }
        public DbSet<LibroEntity> Libros { get; set; }

        public BibliotecaDBContext(DbContextOptions options):base(options) { }
        public BibliotecaDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            AutorEntityConfig.setEntityBuilder(modelBuilder.Entity<AutorEntity>());
            CategoriaEntityConfig.setEntityBuilder(modelBuilder.Entity<CategoriaEntity>());
            LibrosEntityConfig.setEntityBuilder(modelBuilder.Entity<LibroEntity>());

            base.OnModelCreating(modelBuilder);
        }

    }
}

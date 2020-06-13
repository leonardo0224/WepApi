using Biblioteca.DataAcces.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.EntityConfig
{
    public class LibrosEntityConfig
    {

        public static void setEntityBuilder(EntityTypeBuilder<LibroEntity> entityBuilder)
        {
            entityBuilder.ToTable("Libros");
            entityBuilder.HasKey(x => x.IdLibro);
            entityBuilder.Property(x => x.IdLibro).IsRequired();

            entityBuilder.HasOne(x => x.Autor).WithMany(x => x.Libro).HasForeignKey(x=>x.IdAutor);
            entityBuilder.HasOne(x => x.Categoria).WithMany(x => x.Libro).HasForeignKey(x=>x.IdCategoria);

           
        }
    }
}

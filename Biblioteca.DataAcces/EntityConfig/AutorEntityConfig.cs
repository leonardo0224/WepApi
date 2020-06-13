using Biblioteca.DataAcces.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.EntityConfig
{
    public class AutorEntityConfig
    {
        public static void setEntityBuilder(EntityTypeBuilder<AutorEntity> entityBuilder)
        {
            entityBuilder.ToTable("Autores");
            entityBuilder.HasKey(x => x.IdAutor);
            entityBuilder.Property(x => x.IdAutor).IsRequired();
        }
    }
}

using Biblioteca.DataAcces.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.EntityConfig
{
    public class CategoriaEntityConfig
    {

        public static void setEntityBuilder(EntityTypeBuilder<CategoriaEntity> entityBuilder) 
        {
            entityBuilder.ToTable("Categorias");
            entityBuilder.HasKey(x => x.IdCategoria);
            entityBuilder.Property(x => x.IdCategoria).IsRequired();
        }
    }
}

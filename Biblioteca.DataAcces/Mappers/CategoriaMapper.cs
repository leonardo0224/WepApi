using Biblioteca.DataAcces.Contracts.Entities;
using Biblioteca.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.Mappers
{
    public static class CategoriaMapper
    {
        public static CategoriaEntity MapCategoria(Categoria dto)
        {
            return new CategoriaEntity()
            {
                IdCategoria = dto.IdCategoria,
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
            };
        }

        public static Categoria MapCategoria(CategoriaEntity entity)
        {
            return new Categoria()
            {
                IdCategoria = entity.IdCategoria,
                Nombre = entity.Nombre,
                Descripcion = entity.Descripcion,
            };
        }
    }
}

using Biblioteca.DataAcces.Contracts.Entities;
using Biblioteca.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.Mappers
{
    public static class LibroMapper
    {
        public static LibroEntity MapLibros(Libro dto)
        {
            return new LibroEntity()
            {
                IdLibro = dto.IdLibro,
                NombreLibro = dto.NombreLibro,
                IdCategoria = dto.IdCategoria,
                IdAutor = dto.IdAutor,
                ISBN = dto.ISBN,
            };
        }

        public static Libro MapLibros(LibroEntity entity)
        {
            return new Libro()
            {
                IdLibro = entity.IdLibro,
                NombreLibro = entity.NombreLibro,
                IdCategoria = entity.IdCategoria,
                IdAutor = entity.IdAutor,
                ISBN = entity.ISBN,
            };
        }
    }
}

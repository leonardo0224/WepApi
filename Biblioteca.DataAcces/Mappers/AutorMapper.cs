using Biblioteca.DataAcces.Contracts.Entities;
using Biblioteca.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.Mappers
{
    public static class AutorMapper
    {
        public static AutorEntity MapAutor(Autor dto) 
        {
            return new AutorEntity()
            {
                IdAutor = dto.IdAutor,
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                FechaNacimiento = dto.FechaNacimiento,
            };
        }

        public static Autor MapAutor(AutorEntity entity)
        {
            return new Autor()
            {
                IdAutor = entity.IdAutor,
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
               FechaNacimiento = entity.FechaNacimiento,
            };
        }
    }
}

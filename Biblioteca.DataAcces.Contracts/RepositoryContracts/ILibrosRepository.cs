using Biblioteca.DataAcces.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.Contracts.RepositoryContracts
{
    public interface ILibrosRepository : IRepository<LibroEntity>
    {
        // Se agrega metodo especificos para Autores
    }
}

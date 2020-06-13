using Biblioteca.DataAcces.Contracts;
using Biblioteca.DataAcces.Contracts.Entities;
using Biblioteca.DataAcces.Contracts.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DataAcces.Repository
{
    public class LibroRepository : ILibrosRepository
    {
        private readonly IBibliotecaDBContext _BibliotecaDBContext;

        public LibroRepository(IBibliotecaDBContext bibliotecaDBContext)
        {
            _BibliotecaDBContext = bibliotecaDBContext;
        }
        public async Task<LibroEntity> Actualizar(LibroEntity element)
        {
            var entity = await ConsultarId(element.IdLibro);
            entity.NombreLibro = element.NombreLibro;
            entity.IdAutor = element.IdAutor;
            entity.IdCategoria = element.IdCategoria;
            entity.IdLibro = element.IdLibro;
            entity.ISBN = element.ISBN;
            
            _BibliotecaDBContext.Libros.Update(entity);
            await _BibliotecaDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<LibroEntity> Agregar(LibroEntity element)
        {
            await _BibliotecaDBContext.Libros.AddAsync(element);
            await _BibliotecaDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<IEnumerable<LibroEntity>> Consultar()
        {
            return _BibliotecaDBContext.Libros.Select(x => x);
        }

        public async Task<LibroEntity> ConsultarId(int id)
        {
            var result = await _BibliotecaDBContext.Libros.FirstOrDefaultAsync(x => x.IdLibro == id);
            return result;
        }

        public async Task<LibroEntity> EliminarAsync(int id)
        {
            var entity = await _BibliotecaDBContext.Libros.SingleAsync(x => x.IdLibro == id);
            _BibliotecaDBContext.Libros.Remove(entity);
            await _BibliotecaDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }
    }
}

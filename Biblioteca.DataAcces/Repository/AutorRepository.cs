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
    public class AutorRepository : IAutorRepository
    {
        private readonly IBibliotecaDBContext _BibliotecaDBContext;

        public AutorRepository(IBibliotecaDBContext bibliotecaDBContext)
        {
            _BibliotecaDBContext = bibliotecaDBContext;
        }

        public async Task<AutorEntity> Actualizar(AutorEntity autor)
        {

            var entity = await ConsultarId(autor.IdAutor);
            entity.Nombre = autor.Nombre;
            entity.Apellido = autor.Apellido;
            entity.FechaNacimiento = autor.FechaNacimiento;
            entity.Libro = autor.Libro;
            _BibliotecaDBContext.Autores.Update(entity);
            await _BibliotecaDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<AutorEntity> Agregar(AutorEntity element)
        {
            await _BibliotecaDBContext.Autores.AddAsync(element);
            await _BibliotecaDBContext.SaveChangesAsync();
            return element;           
        }

        public async Task<IEnumerable<AutorEntity>> Consultar()
        {
            return _BibliotecaDBContext.Autores.Select(x=>x);
        }

        public async Task<AutorEntity> ConsultarId(int id)
        {
            var result = await _BibliotecaDBContext.Autores.FirstOrDefaultAsync(x => x.IdAutor == id);
            return result;
        }

      
        public async Task<AutorEntity> EliminarAsync(int id)
        {
            var entity = await _BibliotecaDBContext.Autores.SingleAsync(x => x.IdAutor == id);
            _BibliotecaDBContext.Autores.Remove(entity);
            await _BibliotecaDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }
    }
}

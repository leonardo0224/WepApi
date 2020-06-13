using Biblioteca.DataAcces.Contracts;
using Biblioteca.DataAcces.Contracts.Entities;
using Biblioteca.DataAcces.Contracts.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DataAcces.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly IBibliotecaDBContext _BibliotecaDBContext;

        public CategoriaRepository(IBibliotecaDBContext bibliotecaDBContext)
        {
            _BibliotecaDBContext = bibliotecaDBContext;
        }
        public async Task<CategoriaEntity> Actualizar(CategoriaEntity element)
        {
            var entity = await ConsultarId(element.IdCategoria);
            entity.Nombre = element.Nombre;
            entity.Descripcion = element.Descripcion;
            _BibliotecaDBContext.Categorias.Update(entity);
            await _BibliotecaDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<CategoriaEntity> Agregar(CategoriaEntity element)
        {
            await _BibliotecaDBContext.Categorias.AddAsync(element);
            await _BibliotecaDBContext.SaveChangesAsync();
            return element;
        }

        public Task<IEnumerable<CategoriaEntity>> Consultar()
        {
            throw new NotImplementedException();
        }

        public async Task<CategoriaEntity> ConsultarId(int id)
        {
            var result = await _BibliotecaDBContext.Categorias.FirstOrDefaultAsync(x => x.IdCategoria == id);
            return result;
        }

        public async Task<CategoriaEntity> EliminarAsync(int id)
        {
            var entity = await _BibliotecaDBContext.Categorias.SingleAsync(x => x.IdCategoria == id);
            _BibliotecaDBContext.Categorias.Remove(entity);
            await _BibliotecaDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }
    }
}

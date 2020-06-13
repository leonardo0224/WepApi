using Biblioteca.Aplicacion.Contracts.ServicesContracts;
using Biblioteca.DataAcces.Contracts.RepositoryContracts;
using Biblioteca.DataAcces.Mappers;
using Biblioteca.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Services
{
    public class CategoriaServices : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaServices(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        } 
        public async Task<Categoria> Actualizar(Categoria categoria)
        {
            var entidad = await _categoriaRepository.Actualizar(CategoriaMapper.MapCategoria(categoria));
            return CategoriaMapper.MapCategoria(entidad);
        }

        public async Task<Categoria> AgregarCategoria(Categoria categoria)
        {
            var entity = await _categoriaRepository.Agregar(CategoriaMapper.MapCategoria(categoria));
            return CategoriaMapper.MapCategoria(entity);
        }

        public async Task<Categoria> ConsultaId(int id)
        {
            var entidad = await _categoriaRepository.ConsultarId(id);
            return CategoriaMapper.MapCategoria(entidad);
        }

        public async Task<IEnumerable<Categoria>> Consultar()
        {
            var ListaCategoria = await _categoriaRepository.Consultar();
            return ListaCategoria.Select(CategoriaMapper.MapCategoria);
        }

        public async Task<Categoria> EliminarCategoria(int id)
        {
            var entidad = await _categoriaRepository.EliminarAsync(id);
            return CategoriaMapper.MapCategoria(entidad);
        }
    }
}

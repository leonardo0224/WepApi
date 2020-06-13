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
    public class LibrosServices : ILibroServices
    {
        private readonly ILibrosRepository _libroRepository;

        public LibrosServices(ILibrosRepository librosRepository)
        {
            _libroRepository = librosRepository;
        }
        public async Task<Libro> Actualizar(Libro libro)
        {
            var entidad = await _libroRepository.Actualizar(LibroMapper.MapLibros(libro));
            return LibroMapper.MapLibros(entidad);
        }

        public async Task<Libro> AgregarLibro(Libro libro)
        {
            var entidad = await _libroRepository.Agregar(LibroMapper.MapLibros(libro));
            return LibroMapper.MapLibros(entidad);
        }

        public async Task<Libro> ConsultaId(int id)
        {
            var entidad = await _libroRepository.ConsultarId(id);
            return LibroMapper.MapLibros(entidad);
        }

        public async Task<IEnumerable<Libro>> Consultar()
        {
            var listalibros = await _libroRepository.Consultar();
            return listalibros.Select(LibroMapper.MapLibros);
        }

        public async Task<Libro> EliminarLibro(int id)
        {
            var entidad = await _libroRepository.EliminarAsync(id);
            return LibroMapper.MapLibros(entidad);
        }
    }
}

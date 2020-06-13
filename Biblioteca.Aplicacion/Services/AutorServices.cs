using Biblioteca.Aplicacion.Contracts.ServicesContracts;
using Biblioteca.DataAcces.Contracts.RepositoryContracts;
using Biblioteca.DataAcces.Mappers;
using Biblioteca.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Services
{
    public class AutorServices: IAutorService
    {
        private readonly IAutorRepository _autorRepository;

        public AutorServices(IAutorRepository autorRepository) 
        {
            _autorRepository = autorRepository;
        }

        public async Task<Autor> ConsultaId(int id) 
        {
            
            var entidad = await _autorRepository.ConsultarId(id);
            return AutorMapper.MapAutor(entidad);
        }

        public async Task<Autor> AgregarAutor(Autor autor) 
        {
           var entity= await _autorRepository.Agregar(AutorMapper.MapAutor(autor));
            return AutorMapper.MapAutor(entity);
        }

        public async Task<IEnumerable<Autor>> Consultar() 
        {
            var lisautores = await _autorRepository.Consultar();
            return lisautores.Select(AutorMapper.MapAutor);
        }

        public async Task<Autor> EliminarAutor(int id)
        {
            var entidad = await _autorRepository.EliminarAsync(id);
            return AutorMapper.MapAutor(entidad);
        }

        public async Task<Autor> Actualizar(Autor autor)
        {
            var entidad = await _autorRepository.Actualizar(AutorMapper.MapAutor(autor));
            return AutorMapper.MapAutor(entidad);
        }
    }
}

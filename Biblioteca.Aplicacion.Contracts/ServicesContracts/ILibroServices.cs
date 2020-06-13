using Biblioteca.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Contracts.ServicesContracts
{
    public interface ILibroServices
    {
        Task<Libro> ConsultaId(int id);
        Task<Libro> AgregarLibro(Libro autor);
        Task<IEnumerable<Libro>> Consultar();
        Task<Libro> EliminarLibro(int id);
        Task<Libro> Actualizar(Libro autor);
    }
}

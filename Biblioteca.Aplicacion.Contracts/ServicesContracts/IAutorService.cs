using Biblioteca.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Contracts.ServicesContracts
{
    public interface IAutorService
    {
        Task<Autor> ConsultaId(int id);
        Task<Autor> AgregarAutor(Autor autor);
        Task<IEnumerable<Autor>> Consultar();
        Task<Autor> EliminarAutor(int id);

        Task<Autor> Actualizar(Autor autor);

    }
}

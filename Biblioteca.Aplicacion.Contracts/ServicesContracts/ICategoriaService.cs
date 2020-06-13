using Biblioteca.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Aplicacion.Contracts.ServicesContracts
{
    public interface ICategoriaService
    {
        Task<Categoria> ConsultaId(int id);
        Task<Categoria> AgregarCategoria(Categoria autor);
        Task<IEnumerable<Categoria>> Consultar();
        Task<Categoria> EliminarCategoria(int id);
        Task<Categoria> Actualizar(Categoria autor);
    }
}

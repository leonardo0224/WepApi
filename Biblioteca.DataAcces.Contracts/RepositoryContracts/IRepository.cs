using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DataAcces.Contracts.RepositoryContracts
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Exist(int id);

        Task<IEnumerable<T>> Consultar();

        Task<T> ConsultarId(int id);

        Task<T> EliminarAsync(int id);

        Task<T> Actualizar(T element);

        Task<T> Agregar(T element);

    }
}

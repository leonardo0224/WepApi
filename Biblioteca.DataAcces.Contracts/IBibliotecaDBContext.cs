using Biblioteca.DataAcces.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca.DataAcces.Contracts
{
    public interface IBibliotecaDBContext
    {
        DbSet<AutorEntity> Autores { get; set; }
        DbSet<CategoriaEntity> Categorias { get; set; }
        DbSet<LibroEntity> Libros { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);

    }
}

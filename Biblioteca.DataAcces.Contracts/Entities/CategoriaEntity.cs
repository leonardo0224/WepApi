using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.Contracts.Entities
{
    public class CategoriaEntity
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<LibroEntity> Libro { get; set; }

    }
}

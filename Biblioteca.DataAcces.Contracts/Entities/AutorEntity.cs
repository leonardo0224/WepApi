using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.Contracts.Entities
{
    public class AutorEntity
    {
        public int IdAutor { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public virtual ICollection<LibroEntity> Libro { get; set; }
    }
}

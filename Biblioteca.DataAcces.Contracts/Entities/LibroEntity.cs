using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DataAcces.Contracts.Entities
{
    public class LibroEntity
    {
        public int IdLibro { get; set; }

        public  string NombreLibro { get; set; }

        public string  ISBN { get; set; }

        public  int? IdCategoria { get; set; }

        public int? IdAutor { get; set; }

        public virtual CategoriaEntity Categoria { get; set; }

        public virtual AutorEntity Autor { get; set; }
    }
}

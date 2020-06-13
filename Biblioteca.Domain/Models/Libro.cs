using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Models
{
    public class Libro
    {
        public int IdLibro { get; set; }

        public string NombreLibro { get; set; }

        public string ISBN { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdAutor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Models
{
    public class Autor
    {
        public int IdAutor { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}

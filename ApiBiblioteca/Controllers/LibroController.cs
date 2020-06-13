using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Aplicacion.Contracts.ServicesContracts;
using Biblioteca.Domain.Models;
using Microsoft.AspNetCore.Http;
using Biblioteca.Common.Log;
using Microsoft.AspNetCore.Mvc;

namespace ApiBiblioteca.Controllers
{
    [Route("api/libro")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroServices _libroService;

        public LibroController(ILibroServices libroServices)
        {
            _libroService = libroServices;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> get(int id)
        {
            var name = await _libroService.ConsultaId(id);
            Log.EscribirLog("Se reliza consulta de los Libro");
            return Ok(name);
        }

        [HttpGet]
        public async Task<IEnumerable> consultar()
        {
            try
            {
                var libro = await _libroService.Consultar();
                Log.EscribirLog("Se reliza consulta de los Libro"+libro);
                return libro;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> addLibro(Libro libro)
        {
            var name = await _libroService.AgregarLibro(libro);
            Log.EscribirLog("Se reliza agrego de los Libro" + name.NombreLibro);
            return Ok(name);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EleiminarCategoria(int id)
        {
            var name = await _libroService.EliminarLibro(id);
            Log.EscribirLog("Se reliza elimina de los Libro" + name.NombreLibro);
            return Ok(name);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarCategoria(Libro libro)
        {
            var name = await _libroService.Actualizar(libro);
            Log.EscribirLog("Se reliza Actualiza de los Libro" + name.NombreLibro);
            return Ok(name);
        }
    }
}
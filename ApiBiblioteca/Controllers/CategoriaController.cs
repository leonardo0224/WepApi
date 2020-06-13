using System;
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
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> get(int id)
        {
            var name = await _categoriaService.ConsultaId(id);
            Log.EscribirLog("Se reliza consulta de la Categoria" + name.Nombre);
            return Ok(name);
        }

        public async Task<IActionResult> AgregarCategoria(Categoria categoria)
        {
            var name = await _categoriaService.AgregarCategoria(categoria);
            Log.EscribirLog("Se reliza Agrega de la Categoria" + name.Nombre);

            return Ok(name);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> EleiminarCategoria(int id)
        {
            var name = await _categoriaService.EliminarCategoria(id);
            Log.EscribirLog("Se reliza Elimna de la Categoria" + name.Nombre);
            return Ok(name);
        }

        [HttpPut]

        public async Task<IActionResult> ActualizarCategoria(Categoria categoria)
        {
            var name = await _categoriaService.Actualizar(categoria);
            return Ok(name);
        }

        [HttpGet]
        [Produces("application/json", Type = typeof(List<Categoria>))]
        public async Task<IActionResult> consultar()
        {
            var categoria = await _categoriaService.Consultar();
            Log.EscribirLog("Se reliza consulta de la Categoria" );
            return Ok(categoria);
        }
    }
}
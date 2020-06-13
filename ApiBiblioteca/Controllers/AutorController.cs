using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Aplicacion.Contracts.ServicesContracts;
using Biblioteca.Common.Log;
using Biblioteca.Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ApiBiblioteca.Controllers
{
    [Route("api/Autor")]
    [ApiController()]
    public class AutorController : ControllerBase
    {
        private readonly IAutorService _autorService;
        
        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        [HttpGet]
        public async Task<IEnumerable<Autor>> getLibros()
        {
            Log.EscribirLog("Se reliza consulta de los Autor");
            return await _autorService.Consultar(); ;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> get(int id)
        {       
            var name = await _autorService.ConsultaId(id);
            Log.EscribirLog("Se reliza consulta del auto" + name.Nombre);
            return Ok(name);
        }

      
        [HttpPost]
        [Produces("application/json", Type = typeof(Autor))]
        public Autor AgregarAutor([FromBody] Autor autor)
        {
            var name = _autorService.AgregarAutor(autor).GetAwaiter().GetResult();
            Log.EscribirLog("Se reliza Agrega del auto" + name.Nombre);
            return name;
        }
       
        [HttpDelete("{id}")]

        public async Task<IActionResult> EleiminarAutor(int id)
        {
            var name = await _autorService.EliminarAutor(id);
            Log.EscribirLog("Se reliza Elimina del auto" + name.Nombre);
            return Ok(name);
        }
        
        [HttpPut()]

        public async Task<IActionResult> ActualizarActor(Autor autor) 
        {
            var name = await _autorService.Actualizar(autor);
            Log.EscribirLog("Se reliza Actualiza del auto" + name.Nombre);
            return Ok(name);                
        }
    }
}
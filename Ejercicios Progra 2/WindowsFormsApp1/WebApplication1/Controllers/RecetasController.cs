using ClassLibrary1.dominio;
using ClassLibrary1.negocio;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/controller")]
    public class RecetasController : ControllerBase
    {
        private IReceta receta;

        public RecetasController(IReceta receta)
        {
            this.receta = receta;
        }   

        [HttpGet("ingredientes")]
        public IActionResult GetAllIngredientes()
        {
            return Ok(receta.ConsultarIngredientes());
        }

        [HttpPost("guardarReceta")]
        public IActionResult SaveReceta(Receta oReceta) 
        {
            if (oReceta != null)
            {
                return Ok(receta.CreateReceta(oReceta));
            }
            return BadRequest();
        }
    }
}

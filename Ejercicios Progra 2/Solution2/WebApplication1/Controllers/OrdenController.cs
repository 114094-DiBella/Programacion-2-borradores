using ClassLibrary1.Models;
using ClassLibrary1.Negocio.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        private readonly IOrden _iOrden;

        public OrdenController(IOrden orden)
        {
            _iOrden = orden;
        }

        [HttpGet("materiales")]
        public IActionResult  GetMateriales()
        {
            try {
                var materials = _iOrden.ObtenerMateriales();
                return Ok(materials);
            }
            catch(Exception e) { 
                return BadRequest(e.Message);
            }
        }

        [HttpPost("crearOrden")]
        public IActionResult PostOrden(OrdenRetiro ordenRetiro)
        {
            try {
                if (ordenRetiro == null)
                {
                    return BadRequest("La orden de retiro esta vacia");
                }
                _iOrden.CrearOrden(ordenRetiro);
                return Ok("Orden creada");
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("CrearDetalle")]
        public IActionResult PostDetalle(DetalleOrden orden)
        {
            try
            {
                if(orden == null)
                {
                    return BadRequest("El detalle de la orden esta pelado");
                }
                _iOrden.CrearDetalle(orden);
                return Ok("Detalle creado");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

}

using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Negocio.Interface
{
    public interface IOrden
    {
        public List<Material> ObtenerMateriales();
        public bool CrearOrden(OrdenRetiro orden);
        public bool CrearDetalle(DetalleOrden detalle);
    }
}

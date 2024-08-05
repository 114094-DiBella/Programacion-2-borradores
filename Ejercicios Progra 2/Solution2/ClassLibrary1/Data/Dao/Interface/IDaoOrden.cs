using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data.Dao.Interface
{
    public interface IDaoOrden
    {
        List<Material> GetAllMaterials();
        bool CrearOrden(OrdenRetiro ordenRetiro);
        bool CrearDetalle(DetalleOrden detalleOrden);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class DetalleOrden
    {
        

        public int IdDetalle {  get; set; }

        public int OrdenId { get; set; }
        public OrdenRetiro? Orden {get; set; }

        public int MaterialId { get; set; }
        public Material? Material { get; set; }
        public int Cantidad { get; set; }

        public DetalleOrden(int auxDetalle, Material item, int cantidad)
        {
            IdDetalle = auxDetalle;
            Material = item;
            Cantidad = cantidad;
        }
    }
}

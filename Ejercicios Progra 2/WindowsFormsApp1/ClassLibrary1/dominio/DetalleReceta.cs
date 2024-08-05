using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.dominio
{
    public class DetalleReceta
    {
        public int IdDetalle {  get; set; }
        public Ingredientes Ingrediente { get; set; }
        public int Cantidad { get; set; }

        
    }
}

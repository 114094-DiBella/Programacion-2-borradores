using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.dominio
{
    public class Receta
    {
        public int IdReceta { get; set; }
        public string NameReceta { get; set;}
        public int TipoReceta { get; set; }

        public string Cheff {  get; set; }
        public List<DetalleReceta> Detalles { get; set; }


        void AgregarDetalle(DetalleReceta detalle) {
        
            Detalles.Add(detalle);
        }

        void QuitarDetalle(DetalleReceta detalle)
        {
            Detalles.Remove(detalle);
        }

        int CantidadIngredientes()
        {
            int numero = 0;
            foreach (DetalleReceta detalle in Detalles) {

                numero += detalle.Cantidad;
            }
            return numero;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Material
    {
        public int IdMaterial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }

        public Material() {
        }

        public Material(int id, string n, string d, int s)
        {
            IdMaterial = id;
            Nombre = n;
            Descripcion = d;
            Stock = s;
        }
    }
}

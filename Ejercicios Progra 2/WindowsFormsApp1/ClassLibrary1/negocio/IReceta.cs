using ClassLibrary1.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.negocio
{
    public interface IReceta
    {
        public List<Ingredientes> ConsultarIngredientes();

        public bool CreateReceta(Receta receta);
    }
}

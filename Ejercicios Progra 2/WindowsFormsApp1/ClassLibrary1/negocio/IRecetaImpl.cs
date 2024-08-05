using ClassLibrary1.datos;
using ClassLibrary1.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.negocio
{
    public class IRecetaImpl : IReceta
    {
        private IRecetaDao dao;
        public IRecetaImpl (IRecetaDao dao)
        {
            this.dao = dao;
        }
        public List<Ingredientes> ConsultarIngredientes()
        {
            return dao.GetAll();
        }

        public bool CreateReceta(Receta receta)
        {
            return dao.Save(receta);
        }
    }
}

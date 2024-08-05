using ClassLibrary1.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.datos
{
    public interface IRecetaDao
    {
        List<Ingredientes> GetAll();
        bool Save(Receta receta);
    }
}

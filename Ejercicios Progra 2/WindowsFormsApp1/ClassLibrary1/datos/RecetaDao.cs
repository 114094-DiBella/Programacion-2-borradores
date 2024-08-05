using ClassLibrary1.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.datos
{
     public class RecetaDao : IRecetaDao
    {
        private HelperDao dao;

        public RecetaDao(HelperDao dao)
        {
            this.dao = dao;
        }
        public List<Ingredientes> GetAll()
        {
            List<Ingredientes> listIngredientes = new List<Ingredientes>();
            DataTable dt = dao.ConsultarSQL("ObtenerTodosLosIngredientes");
            foreach (DataRow dr in dt.Rows)
            {
                Ingredientes ingredient = new Ingredientes();
                ingredient.Id = Convert.ToInt32(dr[0].ToString());
                ingredient.Name = dr[1].ToString();
                ingredient.Unidad = dr[2].ToString();

                listIngredientes.Add(ingredient);
            }
            return listIngredientes;
        }

        public bool Save(Receta receta)
        {

            string sp = "GuardarReceta";
            string sp2 = "InsertarDetalleReceta";

            return dao.EjecutarInsert(receta,sp,sp2);
        }
    }
}

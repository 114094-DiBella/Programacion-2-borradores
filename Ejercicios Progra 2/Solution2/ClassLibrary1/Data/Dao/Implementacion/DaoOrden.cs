using ClassLibrary1.Data.Dao.Interface;
using ClassLibrary1.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data.Dao.Implementacion
{
    public class DaoOrden : IDaoOrden
    {
        private readonly HelperDB _helper;

        public DaoOrden(HelperDB helperDB) 
        { 
            _helper = helperDB;
        }
       
        public bool CrearDetalle(DetalleOrden detalleOrden)
        {
            bool Ok = true;
            var cnn = _helper.GetConnection();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try {
            
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Connection = cnn;
                cmd.CommandText = "spCrearDetalleOrden";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenId", detalleOrden.Orden.IdOrden);
                cmd.Parameters.AddWithValue("@MaterialId", detalleOrden.Material.IdMaterial);
                cmd.Parameters.AddWithValue("@Cantidad", detalleOrden.Cantidad);
                cmd.ExecuteNonQuery();
                t.Commit();

            } catch (Exception ex) {

                t.Rollback();
                Ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return Ok;
            
        }

        public bool CrearOrden(OrdenRetiro ordenRetiro)
        {
            bool Ok = true;
            var cnn = _helper.GetConnection();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Connection = cnn;
                cmd.CommandText = "spCrearOrden";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", ordenRetiro.Fecha);
                cmd.Parameters.AddWithValue("@Cliente", ordenRetiro.Responsable);
                cmd.ExecuteNonQuery();
                t.Commit();

            }
            catch (Exception ex)
            {

                t.Rollback();
                Ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return Ok;
        }

        public List<Material> GetAllMaterials()
        {
            var list = new List<Material>();
            string sp = "spObtenerMateriales";
            DataTable dt = _helper.ConsultarSql(sp);
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr[0]);
                string name = dr[1].ToString();
                string descripcion = dr[2].ToString();
                int stock = Convert.ToInt32(dr[3].ToString());
                Material material = new Material(id,name,descripcion,stock);
                list.Add(material);
            }
            return list;
        }
    }
}

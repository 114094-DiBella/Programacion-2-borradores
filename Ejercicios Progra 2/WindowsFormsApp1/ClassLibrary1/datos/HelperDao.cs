using System.Data.SqlClient;
using System.Data;
using ClassLibrary1.dominio;

namespace ClassLibrary1.datos
{
    public class HelperDao
    {
        private  HelperDao instancia;
        private readonly string connectionString;

       
        public HelperDao()
        {
            connectionString = @"Data Source=DESKTOP-F08K4QC\SQLEXPRESS;Initial Catalog=recetas_db;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        }
       

        public DataTable ConsultarSQL(string storeName)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storeName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    try
                    {
                        cnn.Open();
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException)
                    {
                        dt = null;
                    }
                    return dt;
                }
            }
        }

        public bool EjecutarInsert(Receta receta, string sp, string spDetalle)
        {
            bool function = true;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlTransaction trans = null;
                try
                {
                    cnn.Open();
                    trans = cnn.BeginTransaction();

                    SqlCommand sqlCommand = new SqlCommand(sp, cnn, trans);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@nombre", receta.NameReceta);
                    sqlCommand.Parameters.AddWithValue("@TipoReceta", receta.TipoReceta);
                    sqlCommand.Parameters.AddWithValue("@cheff", receta.Cheff);

                    SqlParameter recetaIdParam = new SqlParameter("@RecetaID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    sqlCommand.Parameters.Add(recetaIdParam);

                    sqlCommand.ExecuteNonQuery();
                    int recetaId = (int)recetaIdParam.Value;

                    foreach (var detalle in receta.Detalles)
                    {
                        SqlCommand cmdDetalle = new SqlCommand(spDetalle, cnn, trans);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;
                        cmdDetalle.Parameters.AddWithValue("@RecetaID", recetaId);
                        cmdDetalle.Parameters.AddWithValue("@IngredienteID", detalle.Ingrediente);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                catch (SqlException)
                {
                    trans?.Rollback();
                    function = false;
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                    {
                        cnn.Close();
                    }
                }
            }
            return function;
        }

    }
}

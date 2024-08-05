using ModelosDeClases.Datos;
using System.Data.SqlClient;
using System.Data;

public class HelperDb
{
    private static HelperDb instancia;
    private readonly string connectionString;
    private SqlConnection cnn;

    private HelperDb()
    {
        // Asegúrate de que la cadena de conexión sea correcta
        connectionString = "Server=DESKTOP-F08K4QC\\SQLEXPRESS;Database=Formula1DB;Integrated Security=True;";
        cnn = new SqlConnection(connectionString);
    }

    public static HelperDb GetInstance()
    {
        if (instancia == null)
        {
            instancia = new HelperDb();
        }
        return instancia;
    }

    public DataTable ConsultarSql(string sp, List<Parametro> values)
    {
        DataTable dataTable = new DataTable();
        using (var cmd = new SqlCommand(sp, cnn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro p in values)
                {
                    cmd.Parameters.AddWithValue(p.Clave, p.Valor);
                }
            }
            cnn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dataTable.Load(reader);
            }
            cnn.Close();
        }
        return dataTable;
    }

    public int EjecutarSQL(string strSql, List<Parametro> values)
    {
        int afectadas = 0;
        using (var cmd = new SqlCommand(strSql, cnn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro param in values)
                {
                    cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                }
            }
            cnn.Open();
            using (var transaction = cnn.BeginTransaction())
            {
                cmd.Transaction = transaction;
                try
                {
                    afectadas = cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (SqlException)
                {
                    transaction.Rollback();
                }
                finally
                {
                    cnn.Close();
                }
            }
        }
        return afectadas;
    }

    public SqlConnection ObtenerConexion()
    {
        // Devuelve una nueva conexión en lugar de una conexión estática
        return new SqlConnection("Server=DESKTOP-F08K4QC\\SQLEXPRESS;Database=Formula1DB;Integrated Security=True;");
    }

}

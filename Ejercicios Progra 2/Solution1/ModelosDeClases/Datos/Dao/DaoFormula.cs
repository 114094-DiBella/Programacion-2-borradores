using ModelosDeClases.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ModelosDeClases.Datos.Dao
{
    public class DaoFormula : IDaoFormula
    {
        public bool CrearDriver(Driver driver)
        {
            bool ok = true;
            SqlConnection cnn = HelperDb.GetInstance().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Connection = cnn;
                cmd.CommandText = "InsertDriver";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", driver.FirstName);
                cmd.Parameters.AddWithValue("@LastName", driver.LastName);
                cmd.Parameters.AddWithValue("@Nationality", driver.Nationality);
                cmd.Parameters.AddWithValue("@DateOfBirth", driver.DateOfBirth);
                cmd.Parameters.AddWithValue("@TeamId", driver.TeamId);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t?.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }

        public bool CrearRace(Race race)
        {
            throw new NotImplementedException();
        }

        public bool CrearResult(Result result)
        {
            bool ok = true;
            SqlConnection cnn = HelperDb.GetInstance().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try {

                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.Connection = cnn;
                cmd.CommandText = "InsertResult";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RaceId",result.RaceId);
                cmd.Parameters.AddWithValue("@DriverId", result.DriverId);
                cmd.Parameters.AddWithValue("@Position", result.Position);
                cmd.Parameters.AddWithValue("@Points", result.Points);
                cmd.Parameters.AddWithValue("@FasttesLapTime", result.FasttestLapTime);
                cmd.ExecuteNonQuery();
                t.Commit();



            }
            catch (Exception)
            {
                t?.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }

        public List<Driver> ObtenerDrivers()
        {
            var lstDriver = new List<Driver>();
            string sp = "GetAllDrivers";
            DataTable dt = HelperDb.GetInstance().ConsultarSql(sp, null);

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["DriverId"]);
                string firstName = dr["FirstName"].ToString();
                string lastName = dr["LastName"].ToString();
                string nationality = dr["Nationality"].ToString();
                DateTime dateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                int teamId = Convert.ToInt32(dr["TeamId"]);
                Team team = new Team
                {
                    TeamId = teamId,
                    Name = dr["TeamName"].ToString()
                };
                Driver driver = new Driver(id, firstName, lastName, nationality, dateOfBirth, teamId, team);
                lstDriver.Add(driver);
            }
            return lstDriver;
        }

        public async Task<Driver> ObtenerDriversByDriverId(int driverId)
        {
            var driver = new Driver();
            string sp = "GetDriverById";

            try
            {
                using (SqlConnection cnn = HelperDb.GetInstance().ObtenerConexion())
                {
                    if (cnn == null)
                    {
                        throw new InvalidOperationException("La cadena de conexión no está configurada.");
                    }

                    cnn.Open(); // Abre la conexión de manera sincrónica

                    using (SqlCommand cmd = new SqlCommand(sp, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DriverId", driverId);

                        using (SqlDataReader reader = cmd.ExecuteReader()) // Ejecuta la consulta de manera sincrónica
                        {
                            if (reader.Read()) // Lee los datos de manera sincrónica
                            {
                                driver = new Driver
                                {
                                    DriverId = reader.GetInt32(reader.GetOrdinal("DriverId")),
                                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    Nationality = reader.GetString(reader.GetOrdinal("Nationality")),
                                    DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    TeamId = reader.GetInt32(reader.GetOrdinal("TeamId"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Considera usar logging en lugar de simplemente lanzar una excepción
                throw new Exception("Error al obtener el conductor por ID", ex);
            }

            return driver;
        }
    


    public List<Race> ObtenerRace()
        {
            var lstRace = new List<Race>();
            string sp = "GetAllRaces";
            DataTable dt = HelperDb.GetInstance().ConsultarSql(sp, null);
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["RaceId"]);
                string name = dr["Name"].ToString();
                DateTime date = Convert.ToDateTime(dr["Date"]);
                int circuitId = Convert.ToInt32(dr["CircuitId"]);
                Circuits circuits = new Circuits
                {
                    CircuitId = circuitId,
                    Name = dr["RaceName"].ToString()
                };

                Race race = new Race(id, name, date, circuitId, circuits);
                lstRace.Add(race);
            }
            return lstRace;
        }

        public async Task<Race> ObtenerRaceByIdAsync(int raceId)
        {
            var race = new Race();
            string sp = "GetRaceById";

            try
            {
                using (var cnn = HelperDb.GetInstance().ObtenerConexion())
                {
                    if (cnn == null)
                    {
                        throw new InvalidOperationException("La cadena de conexión no está configurada.");
                    }

                    await cnn.OpenAsync(); // Abre la conexión de manera asíncrona

                    using (var cmd = new SqlCommand(sp, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RaceId", raceId);

                        using (var reader = await cmd.ExecuteReaderAsync()) // Ejecuta la consulta de manera asíncrona
                        {
                            if (await reader.ReadAsync()) // Lee los datos de manera asíncrona
                            {
                                race = new Race
                                {
                                    RaceId = reader.GetInt32(reader.GetOrdinal("RaceId")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    CircuitsId = reader.GetInt32(reader.GetOrdinal("CircuitId"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Considera usar logging en lugar de simplemente lanzar una excepción
                throw new Exception("Error al obtener la carrera por ID", ex);
            }

            return race;
        }

        public List<Result> ObtenerResults()
        {
            var lstResult = new List<Result>();
            string sp = "GetAllResult";
            DataTable dt = HelperDb.GetInstance().ConsultarSql(sp, null); 
            foreach(DataRow dr in dt.Rows) {

                Result result = new Result
                {
                    ResultId = Convert.ToInt32(dr["ResultId"]),
                    RaceId = Convert.ToInt32(dr["RaceId"]),
                    DriverId = Convert.ToInt32(dr["DriverId"]),
                    Points = Convert.ToInt32(dr["Points"]),
                    Position = Convert.ToInt32(dr["Position"]),
                    FasttestLapTime = dr["FastestLapTime"].ToString()

                };
                lstResult.Add(result);
            
            }
            return lstResult;
        }

        public List<Team> ObtenerTeams()
        {
            var lstTeam = new List<Team>();
            string sp = "GetAllTeams";
            DataTable dt = HelperDb.GetInstance().ConsultarSql(sp, null);
            foreach (DataRow dr in dt.Rows)
            {
                Team team = new Team
                {
                    TeamId = Convert.ToInt32(dr["TeamId"]),
                    Name = dr["Name"].ToString(),
                    Base = dr["Base"].ToString(),
                    TeamPrincipal = dr["TeamPrincipal"].ToString()
                };
                lstTeam.Add(team);
            }
            return lstTeam;
        }

       
    }
}


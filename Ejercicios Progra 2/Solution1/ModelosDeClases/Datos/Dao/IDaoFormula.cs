using ModelosDeClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDeClases.Datos.Dao
{
    public interface IDaoFormula
    {
         List<Driver> ObtenerDrivers();
         List<Team> ObtenerTeams();
         bool CrearDriver(Driver driver);
            
         bool CrearResult(Result result);
         bool CrearRace (Race race);
         List<Race> ObtenerRace();
        Task<Driver> ObtenerDriversByDriverId(int driverId);
        Task<Race> ObtenerRaceByIdAsync(int raceId);
        List<Result> ObtenerResults();
    }
}

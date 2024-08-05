using ModelosDeClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDeClases.Negocio
{
    public interface IFormulaService
    {   
        public List<Driver> GetDrivers();
        public List<Team> GetTeams();
        public bool SaveDriver (Driver driver);

        public List<Race> GetRaces();
        public bool SaveResult (Result result);
        Task<Race> raceFindByIdAsync(int raceId);
        Task<Driver> driverFindByIdAsync(int driverId);
        List<Result> GetResults();
    }
}

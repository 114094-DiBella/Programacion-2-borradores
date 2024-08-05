using ModelosDeClases.Datos;
using ModelosDeClases.Datos.Dao;
using ModelosDeClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDeClases.Negocio
{
    public class FormulaService : IFormulaService
    {
        private readonly IDaoFormula _dao;

        public FormulaService(IDaoFormula dao)
        {
            _dao = dao;
        }

        public Task<Driver> driverFindByIdAsync(int driverId)
        {
            return _dao.ObtenerDriversByDriverId(driverId);
        }

        public List<Driver> GetDrivers()
        {
            return _dao.ObtenerDrivers();
        }

        public List<Race> GetRaces()
        {
            return _dao.ObtenerRace();
        }

        public List<Result> GetResults()
        {
            return _dao.ObtenerResults();
        }

        public List<Team> GetTeams()
        {
            return _dao.ObtenerTeams();
        }

        public Task<Race> raceFindByIdAsync(int raceId)
        {
            return _dao.ObtenerRaceByIdAsync(raceId);
        }

        public bool SaveDriver(Driver driver)
        {
            return _dao.CrearDriver(driver);
        }

        public bool SaveResult(Result result)
        {
            return _dao.CrearResult(result);
        }
    }
}

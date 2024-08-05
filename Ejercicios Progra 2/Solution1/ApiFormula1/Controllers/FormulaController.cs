using Microsoft.AspNetCore.Mvc;
using ModelosDeClases.Models;
using ModelosDeClases.Negocio;
using System;
using System.Collections.Generic;

namespace ApiFormula1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormulaController : ControllerBase
    {
        private readonly IFormulaService _formulaService;

        public FormulaController(IFormulaService formulaService)
        {
            _formulaService = formulaService;
        }

        [HttpGet("drivers")]
        public IActionResult GetDrivers()
        {
            try
            {
                var drivers = _formulaService.GetDrivers();
                return Ok(drivers);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        [HttpGet("races")]
        public IActionResult GetRaces()
        {
            try
            {
                var races = _formulaService.GetRaces();
                return Ok(races);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("teams")]
        public IActionResult GetTeams()
        {
            try
            {
                var teams = _formulaService.GetTeams();
                return Ok(teams);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("results")]
        public IActionResult GetResults()
        {
            try
            {
                var results = _formulaService.GetResults();
                return Ok(results);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost("CreateDriver")]
        public IActionResult PostDriver(Driver driver)
        {
            try
            {
                if (driver == null)
                {
                    return BadRequest("Error de datos");
                }
                _formulaService.SaveDriver(driver);
                return Ok("Driver creado exitosamente");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost("CreateResult")]
        public async Task<IActionResult> PostResult(Result result)
        {
            try
            {
                if (result == null)
                {
                    return BadRequest("Error de datos");
                }
                var race = await _formulaService.raceFindByIdAsync(result.RaceId);
                var driver = await _formulaService.driverFindByIdAsync(result.DriverId);

                if(race == null || driver == null)
                {
                    return BadRequest("Race or Driver not found.");
                }
                result.Race = race;
                result.Driver = driver;

                _formulaService.SaveResult(result);
                return Ok("Result creado exitosamente");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}


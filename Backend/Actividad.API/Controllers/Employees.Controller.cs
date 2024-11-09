using Actividad.API.Models;
using Actividad.API.Services;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto;

namespace Actividad.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeesController : Controller
    {
        private readonly EmployeesService _employeesService;

        public EmployeesController(EmployeesService EmployeesService)
        {
            _employeesService = EmployeesService;
        }

        [HttpPost("Registrar")]
        public IActionResult RegistrarEmployees([FromBody] Employees employees)
        {
            try
            {
                _employeesService.RegistrarEmployee(employees);
                return Ok(new
                {
                    message = "Empleado registrado"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetEmployees")]
        public ActionResult<IEnumerable<Employees>> GetEmployees()
        {
            try
            {
                var employees = _employeesService.GetEmployees();
                return Ok(employees);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

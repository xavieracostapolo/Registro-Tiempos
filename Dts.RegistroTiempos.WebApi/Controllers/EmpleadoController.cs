using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dts.RegistroTiempos.Model;
using Dts.RegistroTiempos.Model.Dto;
using Dts.RegistroTiempos.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dts.RegistroTiempos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IServiceEmpleado _serviceEmpleado;

        public EmpleadoController(IServiceEmpleado serviceEmpleado)
        {
            this._serviceEmpleado = serviceEmpleado;
        }
        
        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginEmpleadoDto loginEmpleadoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                Empleado model = this._serviceEmpleado.Get(loginEmpleadoDto.Username, loginEmpleadoDto.Password);

                if (model == null)
                    return Unauthorized();

                return Ok(new { model });
            }
            catch (ServiceException ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }

        // POST: api/Empleado
        [HttpPost]
        public IActionResult Post([FromBody] Empleado empleado)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                this._serviceEmpleado.Add(empleado);

                return Ok();
            }
            catch (ServiceException ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }
    }
}

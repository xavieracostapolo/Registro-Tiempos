using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Dts.RegistroTiempos.Model;
using Dts.RegistroTiempos.Model.Dto;
using Dts.RegistroTiempos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dts.RegistroTiempos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private readonly IServiceActividad _serviceActividad;

        public ActividadController(IServiceActividad serviceActividad)
        {
            this._serviceActividad = serviceActividad;
        }

        // GET: api/Actividad
        [HttpGet("{id}")]
        public IEnumerable<Actividad> Get(int id)
        {
            ICollection<Actividad> list = new Collection<Actividad>(); 

            try
            {
                list = _serviceActividad.GetAll(id);

                return list;
            }
            catch (ServiceException ex)
            {
                return new Collection<Actividad>();
            }
        }

        // POST: api/Actividad
        [HttpPost]
        public IActionResult Post([FromBody] ActividadEmpleadoDto actividadEmpleadoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                Actividad model = new Actividad();
                model.Descripcion = actividadEmpleadoDto.Descripcion;
                model.EmpleadoId = actividadEmpleadoDto.EmpleadoId;

                this._serviceActividad.Add(model);

                return Ok();
            }
            catch (ServiceException ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }

    }
}

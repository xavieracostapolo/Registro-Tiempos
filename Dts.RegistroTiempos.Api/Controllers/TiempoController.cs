using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Dts.RegistroTiempos.Model;
using Dts.RegistroTiempos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dts.RegistroTiempos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiempoController : ControllerBase
    {
        private readonly IServiceTiempo _serviceTiempo;

        public TiempoController(IServiceTiempo serviceTiempo)
        {
            this._serviceTiempo = serviceTiempo;
        }
        
        // GET: api/Tiempo/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Tiempo> Get(int id)
        {
            ICollection<Tiempo> list = new Collection<Tiempo>();

            try
            {
                list = _serviceTiempo.GetAll(id);

                return list;
            }
            catch (ServiceException ex)
            {
                return new Collection<Tiempo>();
            }
        }

        // POST: api/Tiempo
        [HttpPost]
        public IActionResult Post([FromBody] Tiempo model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                this._serviceTiempo.Add(model);

                return Ok();
            }
            catch (ServiceException ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }
    }
}

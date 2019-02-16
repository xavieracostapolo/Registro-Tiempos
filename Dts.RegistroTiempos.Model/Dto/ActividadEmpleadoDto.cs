using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Model.Dto
{
    public class ActividadEmpleadoDto
    {

        /// <summary>
        /// Descripcion de la actividad.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Identificador del empleado.
        /// </summary>
        public int EmpleadoId { get; set; }
    }
}

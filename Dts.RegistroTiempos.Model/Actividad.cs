using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Model
{
    /// <summary>
    /// Clase de administracion de actividades
    /// </summary>
    public class Actividad
    {
        /// <summary>
        /// Identificador de la clase.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripcion de la actividad.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Tiempos registrados.
        /// </summary>
        public ICollection<Tiempo> Tiempos { get; set; }

        /// <summary>
        /// Identificador del empleado.
        /// </summary>
        public int EmpleadoId { get; set; }
    }
}

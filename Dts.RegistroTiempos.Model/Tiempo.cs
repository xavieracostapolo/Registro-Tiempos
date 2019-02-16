using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Model
{
    /// <summary>
    /// Clase de administracion de los tiempos.
    /// </summary>
    public class Tiempo
    {
        /// <summary>
        /// Identificador de la clase.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha del registro de tiempos.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Hora gastada en la actividad.
        /// </summary>
        public int Hora { get; set; }

        /// <summary>
        /// Identificador de la actividad que registro el tiempo.
        /// </summary>
        public int ActividadId { get; set; }
    }
}

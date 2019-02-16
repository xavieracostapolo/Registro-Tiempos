using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Model
{
    /// <summary>
    /// Clase de administracion de los empleados
    /// </summary>
    public class Empleado
    {
        /// <summary>
        /// Identificador de la clase empleado.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del empleado.
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Apellido del empleado.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Nombre de usuario.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password del usuario.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Actividades de la clase.
        /// </summary>
        public ICollection<Actividad> Actividades { get; set; }
    }
}

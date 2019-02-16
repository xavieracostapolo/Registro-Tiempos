using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Model.Dto
{
    public class LoginEmpleadoDto
    {
        /// <summary>
        /// Nombre de usuario.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password del usuario.
        /// </summary>
        public string Password { get; set; }
    }
}

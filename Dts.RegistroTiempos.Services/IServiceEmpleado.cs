using Dts.RegistroTiempos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Services
{
    /// <summary>
    /// Interfaz del servicio de empledo.
    /// </summary>
    public interface IServiceEmpleado
    {
        /// <summary>
        /// Obtener el empleado con credenciales validas.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Password de ingreso.</param>
        /// <returns>Retorna objeto tipo empleado.</returns>
        Empleado Get(string username, string password);

        /// <summary>
        /// Guardar un tipo empleado.
        /// </summary>
        /// <param name="model">Objeto tipo empleado.</param>
        void Add(Empleado model);
    }
}

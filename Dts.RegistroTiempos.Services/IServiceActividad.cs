using Dts.RegistroTiempos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Services
{
    /// <summary>
    /// Servicio de la logica de negocio de las actividades.
    /// </summary>
    public interface IServiceActividad
    {
        /// <summary>
        /// Guardar el modelo.
        /// </summary>
        /// <param name="model">Modelo a guardar.</param>
        void Add(Actividad model);

        /// <summary>
        /// Obtener todas las actividades por el id del empleado.
        /// </summary>
        /// <param name="idEmpleado">Id del empleado.</param>
        /// <returns>Coleccion de actividades.</returns>
        ICollection<Actividad> GetAll(int idEmpleado);
    }
}

using Dts.RegistroTiempos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Services
{
    /// <summary>
    /// Servicio de la logica de negocio del registro de tiempos.
    /// </summary>
    public interface IServiceTiempo
    {
        /// <summary>
        /// Guardar el modelo.
        /// </summary>
        /// <param name="model">Modelo a guardar.</param>
        void Add(Tiempo model);

        /// <summary>
        /// Obtener todas los tiempos por el id de la actividad.
        /// </summary>
        /// <param name="idEmpleado">Id del empleado.</param>
        /// <returns>Coleccion de tiempos.</returns>
        ICollection<Tiempo> GetAll(int idActividad);
    }
}

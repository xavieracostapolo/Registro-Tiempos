using Dts.RegistroTiempos.Data;
using Dts.RegistroTiempos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Dts.RegistroTiempos.Services
{
    /// <summary>
    /// Servicio de la logica de negocio de las actividades.
    /// </summary>
    public class ServiceActividad: IServiceActividad
    {
        /// <summary>
        /// Context de acceso a datos.
        /// </summary>
        private readonly TiemposDbContext _context;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="context">Contexto de acceso a datos.</param>
        public ServiceActividad(TiemposDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Guardar el modelo.
        /// </summary>
        /// <param name="model">Modelo a guardar.</param>
        public void Add(Actividad model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error guardando activida.", ex);
            }
        }

        /// <summary>
        /// Obtener todas las actividades por el id del empleado.
        /// </summary>
        /// <param name="idEmpleado">Id del empleado.</param>
        /// <returns>Coleccion de actividades.</returns>
        public ICollection<Actividad> GetAll(int idEmpleado)
        {
            try
            {
                ICollection<Actividad> list = new Collection<Actividad>();
                list = _context.Actividades.Where(a => a.EmpleadoId == idEmpleado).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error consultando actividades.", ex);
            }
        }
    }
}

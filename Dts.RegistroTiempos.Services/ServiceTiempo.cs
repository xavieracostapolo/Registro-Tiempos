using Dts.RegistroTiempos.Data;
using Dts.RegistroTiempos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Dts.RegistroTiempos.Services
{
    public class ServiceTiempo: IServiceTiempo
    {
        /// <summary>
        /// Context de acceso a datos.
        /// </summary>
        private readonly TiemposDbContext _context;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="context">Contexto de acceso a datos.</param>
        public ServiceTiempo(TiemposDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Guardar el modelo.
        /// </summary>
        /// <param name="model">Modelo a guardar.</param>
        public void Add(Tiempo model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error guardando tiempo.", ex);
            }
        }

        /// <summary>
        /// Obtener todas los tiempos por el id de la actividad.
        /// </summary>
        /// <param name="idActividad">Id de la actividad.</param>
        /// <returns>Coleccion de tiempos.</returns>
        public ICollection<Tiempo> GetAll(int idActividad)
        {
            try
            {
                ICollection<Tiempo> list = new Collection<Tiempo>();
                list = _context.Tiempos.Where(t => t.ActividadId == idActividad).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error consultando tiempos.", ex);
            }
        }
    }
}

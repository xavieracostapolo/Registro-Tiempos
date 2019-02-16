using Dts.RegistroTiempos.Data;
using Dts.RegistroTiempos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dts.RegistroTiempos.Services
{
    /// <summary>
    /// Servicio de la logica del servicio empleado.
    /// </summary>
    public class ServiceEmpleado : IServiceEmpleado
    {
        /// <summary>
        /// Context de acceso a datos.
        /// </summary>
        private readonly TiemposDbContext _context;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="context">Contexto de acceso a datos.</param>
        public ServiceEmpleado(TiemposDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Guardar un tipo empleado.
        /// </summary>
        /// <param name="model">Objeto tipo empleado.</param>
        public void Add(Empleado model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error guardando empleado.", ex);
            }
        }

        /// <summary>
        /// Obtener el empleado con credenciales validas.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Password de ingreso.</param>
        /// <returns>Retorna objeto tipo empleado.</returns>
        public Empleado Get(string username, string password)
        {
            try
            {
                Empleado empleado; 
                empleado = _context.Empleados.SingleOrDefault(e => e.Username == username && e.Password == password);
                return empleado;
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error consultando empleado", ex);
            }
        }
    }
}

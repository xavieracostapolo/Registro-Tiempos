using Dts.RegistroTiempos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dts.RegistroTiempos.Data
{
    /// <summary>
    /// Clase de acceso a datos
    /// </summary>
    public class TiemposDbContext : DbContext
    {

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="options"></param>
        public TiemposDbContext(DbContextOptions<TiemposDbContext> options)
            :base(options)
        {
        }

        /// <summary>
        /// Contexto de la clase empleados para acceder a los datos.
        /// </summary>
        public DbSet<Empleado> Empleados { get; set; }

        /// <summary>
        /// Contexto de la clase actividades para acceder a los datos.
        /// </summary>
        public DbSet<Actividad> Actividades { get; set; }

        /// <summary>
        /// Contexto de la clase tiempos para acceder a los datos.
        /// </summary>
        public DbSet<Tiempo> Tiempos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().ToTable("Empleado");
            modelBuilder.Entity<Actividad>().ToTable("Actividad");
            modelBuilder.Entity<Tiempo>().ToTable("Tiempo");
        }
    }
}

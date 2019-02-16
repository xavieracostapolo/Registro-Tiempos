using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dts.RegistroTiempos.Data
{
    /// <summary>
    /// Clase que se crea cuando entity framework queda en un proycto diferente a la aplicacion
    /// </summary>
    public class MyDbContextFactory : IDesignTimeDbContextFactory<TiemposDbContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        TiemposDbContext IDesignTimeDbContextFactory<TiemposDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<TiemposDbContext>();
            var connectionString = configuration.GetConnectionString("Dev");

            builder.UseSqlServer(connectionString);

            return new TiemposDbContext(builder.Options);
        }
    }
}

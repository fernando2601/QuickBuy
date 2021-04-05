using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuickBuy.Repositorio
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<QuickBuyContexto>
    {
        public QuickBuyContexto CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<QuickBuyContexto>();
            var connectionString = configuration.GetConnectionString("SqlServerConnection");
            builder.UseSqlServer(connectionString);
            return new QuickBuyContexto(builder.Options);
        }
    }
}

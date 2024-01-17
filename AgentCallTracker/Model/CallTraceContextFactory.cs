using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgentCallTracker.API.Model
{
    public class CallTraceContextFactory
    {
        public CallTraceDbContext Create()
        {
            var environmentName = Environment.GetEnvironmentVariable("Hosting:Environment");
            var basePath = AppContext.BaseDirectory;
            return Create(basePath, environmentName);
        }
        public CallTraceDbContext Create(DbContextFactoryOptions options)
        {

            return Create(Directory.GetCurrentDirectory(), Environment.GetEnvironmentVariable("Hosting:Environment"));
        }
        private CallTraceDbContext Create(string basePath, string environmentName)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{environmentName}.json", true)
            .AddEnvironmentVariables();

            var config = builder.Build();
            var connstr = config.GetConnectionString("DefaultConnection");

            if (string.IsNullOrWhiteSpace(connstr) == true)
            {
                throw new InvalidOperationException(
                "Could not find a connection string named '(DefaultConnection)'.");
            }
            else
            {
                return Create(connstr);
            }
        }
        private CallTraceDbContext Create(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException(
                $"{nameof(connectionString)} is null or empty.",
                nameof(connectionString));

            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(connectionString);
            return new CallTraceDbContext(optionsBuilder.Options);
        }
    }
}

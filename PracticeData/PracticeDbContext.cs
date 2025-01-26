using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PracticeData
{
    public class PracticeDbContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

    public static class ContextRegistry
    {
        public static IServiceCollection RegisterContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PracticeDbContext>(option =>
            {
                option.UseNpgsql(configuration.GetConnectionString("Practice"));
            });
            return services;
        }
    }
}

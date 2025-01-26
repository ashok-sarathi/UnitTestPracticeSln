using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PracticeBusiness.Services;

namespace PracticeBusiness.Helpers
{
    public static class ServiceRegistory
    {
        public static IServiceCollection RegistorBusiness(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}

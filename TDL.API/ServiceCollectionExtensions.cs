using Microsoft.Extensions.DependencyInjection;
using TDL.Repository;
using TDL.Services;

namespace TDL.API
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPatientRepository, PatientRepository>();

            return services;
        }


        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPatientService, PatientService>();

            return services;
        }
    }
}

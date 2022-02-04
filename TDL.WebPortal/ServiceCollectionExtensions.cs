using Microsoft.Extensions.DependencyInjection;
using TDL.Portal.Data;
using TDL.Portal.Services;


namespace TDL.WebPortal
{

    public static class ServiceCollectionExtensions
    {
      
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddTransient<IPatientService, PatientService>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // Provide the orchestrator api settings object via the di container.
            services.AddHttpClient<IPatientRepository, PatientRepository>();
            return services;
        }
    }
}

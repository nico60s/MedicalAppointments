

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalAppointment.Auth
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuthModuleConfiguration(this IServiceCollection services,
                                                                    IConfiguration configuration) 
        {
           
            return services;
        }
    }
}

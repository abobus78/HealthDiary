using HealthDiary.GenericRepositories;
using HealthDiary.IGenericRepositories;
using HealthDiary.Interfaces;
using HealthDiary.Service;

namespace HealthDiary.Helpers
{
    public static class ServiceExtension
    {
        public static void RegistrationServices(this IServiceCollection services)
        {
            services.AddTransient<IRegistrationService, RegistrationService>();
            services.AddScoped<ICalculateCaloriesService, CalculateCaloriesService>();
            services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
        }
    }
}

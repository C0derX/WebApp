using CMS.Context.Repository.Implementations;
using CMS.Service.Assemblers.Implementaions;
using CMS.Service.Assemblers.Interface;
using CMS.Service.Repository.Interface;
using CMS.Service.Services.Implementations;
using CMS.Service.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CMS.Context
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCMSLibrary(this IServiceCollection services)
        {
            registerRepositories(services);
            registerAssemblers(services);
            registerServices(services);
            return services;
        }

        private static void registerServices(IServiceCollection services)
        {
            services.AddScoped<RegisterService, RegisterServiceImpl>();
            services.AddScoped<SeminarService, SeminarServiceImpl>();
            services.AddScoped<OrganizerService, OrganizerServiceImpl>();
            services.AddScoped<StudentService, StudentServiceImpl>();
        }

        private static void registerAssemblers(IServiceCollection services)
        {
            services.AddScoped<RegisterAsssembler, RegisterAssemblerImpl>();
            services.AddScoped<SeminarAssembler, SeminarAssemblerImpl>();
            services.AddScoped<OrganizerAssembler, OrganizerAssemblerImpl>();
            services.AddScoped<StudentAssembler, StudentAssemblerImpl>();

        }

        private static void registerRepositories(IServiceCollection services)
        {
            services.AddScoped<RegisterRepository, RegisterRepositoryImpl>();
            services.AddScoped<SeminarRepository, SeminarRepositoryImpl>();
            services.AddScoped<OrganizerRepository, OrganizerRepositoryImpl>();
            services.AddScoped<StudentRepository, StudentRepositoryImpl>();

        }
    }
}

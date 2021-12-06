using Core.Common.Helpers;
using Core.Common.Library.Implementations;
using Core.Common.Library.Interface;
using Core.Common.Repository.Implementations;
using Core.Common.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Context.Repository.Implementations;
using UserManagement.Service.Assemblers.Implementations;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Implementations;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Context
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCommonLibrary(this IServiceCollection services)
        {
            registerRepositories(services);
            registerAssemblers(services);
            registerServices(services);
            registerHelpers(services);

            return services;
        }

        private static void registerServices(IServiceCollection services)
        {
            services.AddScoped<AuthenticationService, AuthenticationServiceImpl>();
            services.AddScoped<JwtTokenService, JwtTokenServiceImpl>();
            services.AddScoped<MailFormatService, MailFormatServiceImpl>();
            services.AddScoped<MenuService, MenuServiceImpl>();
            services.AddScoped<ModuleService, ModuleServiceImpl>();
            services.AddScoped<RandomKeyGeneratorService, RandomKeyGeneratorServiceImpl>();
            services.AddScoped<RoleMenuMapService, RoleMenuMapServiceImpl>();
            services.AddScoped<RoleService, RoleServiceImpl>();
            services.AddScoped<UserDetailService, UserDetailServiceImpl>();
            services.AddScoped<RolePermissionMapService, RolePermissionMapServiceImpl>();
            services.AddScoped<UserRoleMapService, UserRoleMapServiceImpl>();
            services.AddScoped<UserService, UserServiceImpl>();
            services.AddScoped<OrganizationService, OrganizationServiceImpl>();
            services.AddScoped<OrganizationModuleMapService, OrganizationModuleMapServiceImpl>();
        }

        private static void registerAssemblers(IServiceCollection services)
        {
            services.AddScoped<MenuAssembler, MenuAssemblerImpl>();
            services.AddScoped<ModuleAssembler, ModuleAssemblerImpl>();
            services.AddScoped<RoleAssembler, RoleAssemblerImpl>();
            services.AddScoped<UserAssembler, UserAssemblerImpl>();
            services.AddScoped<UserDetailAssembler, UserDetailAssemblerImpl>();
            services.AddScoped<OrganizationAssembler, OrganizationAssemblerImpl>();
        }

        private static void registerHelpers(IServiceCollection services)
        {
            services.AddScoped<PasswordHash, PasswordHashImpl>();
            services.AddScoped<Cryptography, CryptographyImpl>();
            services.AddScoped<FileHelper, FileHelperImpl>();
        }

        private static void registerRepositories(IServiceCollection services)
        {
            services.AddScoped<JwtTokenRepository, JwtTokenRepositoryImpl>();
            services.AddScoped<MenuPermissionMapRepository, MenuPermissionMapRepositoryImpl>();
            services.AddScoped<MenuRepository, MenuRepositoryImpl>();
            services.AddScoped<ModuleRepository, ModuleRepositoryImpl>();
            services.AddScoped<RoleMenuMapRepository, RoleMenuMapRepositoryImpl>();
            services.AddScoped<RoleRepository, RoleRepositoryImpl>();
            services.AddScoped<UserDetailRepository, UserDetailRepositoryImpl>();
            services.AddScoped<UserLoggedInStatusRepository, UserLoggedInStatusRepositoryImpl>();
            services.AddScoped<RolePermissionMapRepository, RolePermissionMapRepositoryImpl>();
            services.AddScoped<UserRepository, UserRepositoryImpl>();
            services.AddScoped<UserRoleMapRepository, UserRoleMapRepositoryImpl>();
            services.AddScoped<OrganizationRepository, OrganizationRepositoryImpl>();
            services.AddScoped<OrganizationModuleMapRepository, OrganizationModuleMapRepositoryImpl>();
            services.AddScoped(typeof(BaseRepository<>), typeof(BaseRepositoryImpl<>));
        }

    }
}

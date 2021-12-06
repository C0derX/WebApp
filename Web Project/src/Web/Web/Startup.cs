using AutoMapper;
using CMS.Context;
using Core.Context;
using Core.Library.UnitOfWork;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using UserManagement.Context;
using UserManagement.Service.Services.Implementations;
using UserManagement.Service.Services.Interface;
using Web.Areas.UserManagement.Models;
using Web.Pagination;
using Web.PermissionHandler;

namespace Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Web"));
            });

            services.AddScoped<EmailSenderService, EmailSenderServiceImpl>(i =>
               new EmailSenderServiceImpl(
                   Configuration["EmailSender:Host"],
                   Configuration.GetValue<int>("EmailSender:Port"),
                   Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                   Configuration["EmailSender:UserName"],
                   Configuration["EmailSender:Password"]
               )
           );

            registerElements(services);
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();
            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
            {
                options.Cookie.HttpOnly = false;
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = "/UserManagement/account/login";
                options.LogoutPath = "/UserManagement/account/logout";
                options.AccessDeniedPath = "/error";

            });


            services.AddAuthorization(options =>
            {
                options.AddPolicy(UserTypeClaims.organisationAdminPolicy, policyBuilder =>
                {
                    policyBuilder.RequireAuthenticatedUser()
                        .RequireAssertion(context =>
                            context.User.HasClaim(UserTypeClaims.normalUserClaim, UserTypeClaims.normalUserClaim))

                        .Build();
                });


            });

            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options => options.DataAnnotationLocalizerProvider = (t, f) => f.Create(typeof(SharedResource)));

            services.AddResponseCaching();
            services.AddLocalization(opts => { opts.ResourcesPath = "Resources"; });
            services.Configure<RequestLocalizationOptions>(
       opts =>
       {
           var supportedCultures = new List<CultureInfo>
           {
                new CultureInfo("en"),
                new CultureInfo("ne-NP"),
           };
           opts.DefaultRequestCulture = new RequestCulture("ne-Np");
           opts.SupportedCultures = supportedCultures;
           opts.SupportedUICultures = supportedCultures;
       });
            services.AddSession();
        
            services.AddSingleton<IAuthorizationPolicyProvider, AuthorizationPolicyProvider>();
            services.AddTransient<IAuthorizationHandler, PermissionHandler.PermissionHandler>();
            services.AddScoped<PaginatedMetaService, PaginatedMetaServiceImpl>();

        }

        private void registerElements(IServiceCollection services)
        {
            registerActualImplementation(services);
        }

        private void registerActualImplementation(IServiceCollection services)
        {
            services.AddCommonLibrary();
            services.AddCMSLibrary();
            services.AddScoped<UnitOfWork, UnitOfWorkImpl>();
            registerHelpers(services);
        }

        private void registerHelpers(IServiceCollection services)
        {
            registerWebHelpers(services);
        }

        private void registerWebHelpers(IServiceCollection services)
        {
            //  services.AddScoped<JwtFactory, JwtFactoryImpl>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/Error/{0}");
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/error/{0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}

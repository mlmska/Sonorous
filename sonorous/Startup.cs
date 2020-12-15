using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sonorous.Core.Convertors.SendEmail;
using sonorous.Core.Services;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Context;

namespace sonorous
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);


            #region Authentiacation

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme= CookieAuthenticationDefaults.AuthenticationScheme;


            }).AddCookie(options=>
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
            });

            #endregion

            #region Database context
            services.AddDbContext<SonorousContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("SonorousConnection_db"));
                }
                );
            #endregion

            #region IoC

            services.AddTransient<IUserServices, UserServices>();
            services.AddTransient<IViewRenderService, RenderViewToString>();
            services.AddTransient<IPermissionService,PermissonService>();
            services.AddTransient<IProductServices, ProdcutServices>();
            services.AddTransient<IOrderServices, OrderServices>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}"); 
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

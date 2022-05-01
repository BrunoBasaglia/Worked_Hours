using Clock.Application.Interfaces;
using Clock.Application.Services;
using Clock.Auth.IdentityContext;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using Clock.Domain.Services;
using Clock.Infra.Context;
using Clock.Infra.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Clock.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            //AUTH
            services.AddDbContext<AuthContext>(options => options.UseSqlServer(connection));
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AuthContext>();//
            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AuthContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.ConfigureApplicationCookie(options =>
            {
                options.Events = new CookieAuthenticationEvents
                {
                    OnRedirectToLogin = x =>
                    {
                        x.Response.Redirect("/Login");
                        return Task.CompletedTask;
                    }
                };
            });


            //INFRA
            services.AddDbContext<ClockContext>(options => options.UseSqlServer(connection));

            services.AddScoped(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            services.AddScoped<IPersonAppService, PersonAppService>();
            services.AddScoped<IEmployerAppService, EmployerAppService>();
            services.AddScoped<IPersonEmployerAppService, PersonEmployerAppService>();
            //services.AddScoped<IAddressAppService, AddressAppService>();
            services.AddScoped<IStateAppService, StateAppService>();
            services.AddScoped<ICityAppService, CityAppService>();
            services.AddScoped<IHoursAppService, HoursAppService>();
            services.AddScoped<IClientAppService, ClientAppService>();
            services.AddScoped<IFrequencyAppService, FrequencyAppService>();

            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IEmployerService, EmployerService>();
            services.AddScoped<IPersonEmployerService, PersonEmployerService>();
            //services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IStateService, StateService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IHoursService, HoursService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IFrequencyService, FrequencyService>();

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IEmployerRepository, EmployerRepository>();
            services.AddScoped<IPersonEmployerRepository, PersonEmployerRepository>();
            //services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IHoursRepository, HoursRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IFrequencyRepository, FrequencyRepository>();
        }
    }
}

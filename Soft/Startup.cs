using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Domain.Order;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.Order;
using SemestriProject.Infra.RoadFreight;
using SemestriProject.Infra.SeaFreight;
using SemestriProject.Soft.Data;

namespace SemestriProject.Soft
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<RoadFreightDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<SeaFreightDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<AirFreightDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<OrderDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddScoped<IBalticsRepository, BalticsRepository>();
            services.AddScoped<IRussiaCISRepository, RussiaCISRepository>();
            services.AddScoped<IScandinaviasRepository, ScandinaviasRepository>();
            services.AddScoped<IEuropeRepository, EuropeRepository>();
            services.AddScoped<IAfricaRepository, AfricaRepository>();
            services.AddScoped<IAmericaRepository, AmericaRepository>();
            services.AddScoped<IAustraliaRepository, AustraliaRepository>();
            services.AddScoped<IChinaRepository, ChinaRepository>();
            services.AddScoped<IMakeOrderRepository, MakeOrderRepository>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs;
using RFSolucoes.SGE.Dominio.Interfaces.DAOs.Cadastros;
using RFSolucoes.SGE.Dominio.Interfaces.Servicos.Cadastros;
using RFSolucoes.SGE.Negocio.Servicos.Cadastros;
using RFSolucoes.SGE.Repositorio;
using RFSolucoes.SGE.Repositorio.DAOs;
using RFSolucoes.SGE.Repositorio.DAOs.Cadastros;

namespace RFSolucoes.SGE.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<SGEContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IProdutoServico, ProdutoServico>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute("Cadastros", "Cadastros", "Cadastros/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute("Financeiro", "Financeiro", "Financeiro/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

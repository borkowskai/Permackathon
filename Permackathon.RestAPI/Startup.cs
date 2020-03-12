using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Permackaathon.Customer.BLL.UseCases;
using Permackathon.Common.CustomersManager.Interfaces.IRepositories;
using Permackathon.Common.CustomersManager.Interfaces.UseCases;
using Permackathon.Common.FinancialManager.Interfaces.IRepositories;
using Permackathon.Common.FinancialManager.Interfaces.UseCases;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.Interfaces.UseCases;
using Permackathon.Customer.BLL.UseCases;
using Permackathon.Customer.DAL;
using Permackathon.Customer.DAL.Repositories;
using Permackathon.Financial.BLL.UseCases;

using Permackathon.Financial.DAL;
using Permackathon.Issues.BLL.UseCases;
using Permackathon.Issues.DAL;

namespace Permackathon.API
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
            //FinancialManagement -> Injections de dépendance
            services.AddDbContext<FinancialContext>();
            services.AddScoped<IFMUnitOfWork, FinancialUnitOfWork>();
            services.AddScoped<IFMUser, FMUser>();
            services.AddScoped<IAccountant, Accountant>();
            services.AddScoped<IMasterAccountant, MasterAccountant>();



            //CustomerManagement -> Injections de dépendance
            services.AddDbContext<CustomersManagerContext>();
            services.AddScoped<ICMCommercial, CMCommercial>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICMUser, CMUser>();

            //IssuesManagement -> Injections de dépendance
            services.AddDbContext<IssuesContext>();
            services.AddScoped<IIssuesUnitOfWork, IssuesUnitOfWork>();
            services.AddScoped<IUser, User>();
            


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

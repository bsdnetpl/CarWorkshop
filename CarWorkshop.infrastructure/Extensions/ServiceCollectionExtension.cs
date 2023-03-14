using CarWorkshop.Domain.Interfaces;
using CarWorkshop.infrastructure.Persistance;
using CarWorkshop.infrastructure.Repository;
using CarWorkshop.infrastructure.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.infrastructure.Extensions
{
    public static class ServiceCollectionExtension 
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<CarWorkshopeDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("CarWorkshop")).LogTo(Console.WriteLine));
            services.AddScoped<CarWorkShopSeeder>();
            services.AddScoped<ICarWorkshopRepository, CarWorkshopRepository>();
        }

       

    }
}

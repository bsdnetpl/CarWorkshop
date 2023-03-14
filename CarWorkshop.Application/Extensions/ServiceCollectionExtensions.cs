using CarWorkshop.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.Extensions {
    public static class ServiceCollectionExtensions 
    {
        public static void AddApplication(this IServiceCollection service) 
        {
            service.AddScoped<ICarWorkshopService, CarWorkshopService>();

        }
    }
}

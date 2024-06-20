using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Abstractions;
using Test.Infrastructure.Persistence;

namespace Test.Infrastructure
{
    public static class TestInfrastructureDI
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ITestDbContext, TestDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("TestPortal"));
            });

            return services;
        }
    }
}

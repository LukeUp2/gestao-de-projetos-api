using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Infra;
using GestaoDeProjetos.Api.Infra.Data.Repositories;
using GestaoDeProjetos.Api.UseCases.Project.Create;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeProjetos.Api.Extensions
{
    public static class ApplicationExtensions
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddUseCases(services);
            AddRepositories(services);
        }


        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<CreateProjectUseCase>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<ProjectRepository>();
            services.AddScoped<TaskRepository>();
        }

    }
}
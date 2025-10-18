using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Infra;
using GestaoDeProjetos.Api.Infra.Data.Repositories;
using GestaoDeProjetos.Api.UseCases.Project.Create;
using GestaoDeProjetos.Api.UseCases.Project.ListAll;
using GestaoDeProjetos.Api.UseCases.Tasks.Create;
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
            AddUnitOfWork(services);
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
            //Projects
            services.AddScoped<CreateProjectUseCase>();
            services.AddScoped<ListAllProjectsUseCase>();

            //Tasks
            services.AddScoped<CreateTaskUseCase>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<ProjectRepository>();
            services.AddScoped<TaskRepository>();
        }

        private static void AddUnitOfWork(IServiceCollection services)
        {
            services.AddScoped<UnitOfWork>();
        }

    }
}
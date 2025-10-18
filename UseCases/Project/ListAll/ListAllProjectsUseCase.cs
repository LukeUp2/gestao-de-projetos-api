using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Extensions;
using GestaoDeProjetos.Api.Infra.Data.Repositories;
using GestaoDeProjetos.Api.Responses;

namespace GestaoDeProjetos.Api.UseCases.Project.ListAll
{
    public class ListAllProjectsUseCase
    {
        private readonly ProjectRepository _projectRepository;

        public ListAllProjectsUseCase(ProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<ResponseProjectJson>> Execute()
        {
            var projects = await _projectRepository.ListAll();
            return projects.Select(item =>
            {
                return item.ToResponse();
            }).ToList();
        }
    }
}
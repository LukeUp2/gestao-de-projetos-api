using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Extensions;
using GestaoDeProjetos.Api.Infra.Data.Repositories;
using GestaoDeProjetos.Api.Requests;
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

        public async Task<ResponseListAllProjectsJson> Execute(PaginationQueryRequest? query)
        {
            var page = query?.Page ?? 1;
            var perPage = query?.PerPage ?? 3;

            var projects = await _projectRepository.ListAll(page, perPage);

            return new ResponseListAllProjectsJson
            {
                Items = projects.Select(item => item.ToResponse()).ToList(),
                Page = page,
                Total = perPage
            };
        }
    }
}
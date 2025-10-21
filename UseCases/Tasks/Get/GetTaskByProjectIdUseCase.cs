using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Exceptions;
using GestaoDeProjetos.Api.Extensions;
using GestaoDeProjetos.Api.Infra.Data.Repositories;
using GestaoDeProjetos.Api.Requests;
using GestaoDeProjetos.Api.Responses;

namespace GestaoDeProjetos.Api.UseCases.Tasks.Get
{
    public class GetTaskByProjectIdUseCase
    {
        private readonly ProjectRepository _projectRepository;
        private readonly TaskRepository _taskRepository;

        public GetTaskByProjectIdUseCase(ProjectRepository projectRepository, TaskRepository taskRepository)
        {
            _projectRepository = projectRepository;
            _taskRepository = taskRepository;
        }

        public async Task<List<ResponseTaskJson>> Execute(TaskRouteFilterRequest request)
        {
            var projectExists = await _projectRepository.CheckIfProjectExists(request.ProjectId);

            if (!projectExists)
            {
                throw new NotFoundException("Project not found, please try again");
            }

            var tasks = await _taskRepository.GetTaskByProjectId(request);
            return tasks.Select(task => task.ToResponse()).ToList();
        }
    }
}
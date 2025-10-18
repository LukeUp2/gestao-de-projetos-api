using System;
using System.Collections.Generic;
using System.Linq;
using GestaoDeProjetos.Api.Exceptions;
using GestaoDeProjetos.Api.Extensions;
using GestaoDeProjetos.Api.Infra.Data.Repositories;
using GestaoDeProjetos.Api.Requests;
using GestaoDeProjetos.Api.Responses;

namespace GestaoDeProjetos.Api.UseCases.Tasks.Create
{
    public class CreateTaskUseCase
    {
        private readonly TaskRepository _taskRepository;
        private readonly ProjectRepository _projectRepository;
        private readonly UnitOfWork _unitOfWork;

        public CreateTaskUseCase(TaskRepository taskRepository, UnitOfWork unitOfWork, ProjectRepository projectRepository)
        {
            _taskRepository = taskRepository;
            _unitOfWork = unitOfWork;
            _projectRepository = projectRepository;
        }

        public async System.Threading.Tasks.Task Execute(CreateTaskRequestJson request)
        {
            Validate(request);
            var projectExists = await _projectRepository.CheckIfProjectExists(request.ProjectId);

            if (projectExists.IsFalse())
            {
                throw new NotFoundException("Project not found, please try again");
            }

            var entity = request.ToEntity();

            await _taskRepository.Create(entity);
            await _unitOfWork.Commit();
        }

        private void Validate(CreateTaskRequestJson request)
        {
            var validator = new CreateTaskUseCaseValidator();
            var result = validator.Validate(request);

            if (result.IsValid.IsFalse())
            {
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).ToList());
            }
        }
    }
}
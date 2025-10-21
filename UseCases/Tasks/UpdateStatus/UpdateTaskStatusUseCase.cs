using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Exceptions;
using GestaoDeProjetos.Api.Infra.Data.Repositories;
using GestaoDeProjetos.Api.Requests;
using GestaoDeProjetos.Api.Responses;

namespace GestaoDeProjetos.Api.UseCases.Tasks.UpdateStatus
{
    public class UpdateTaskStatusUseCase
    {
        private readonly TaskRepository _taskRepository;
        private readonly UnitOfWork _unitOfWork;

        public UpdateTaskStatusUseCase(TaskRepository taskRepository, UnitOfWork unitOfWork)
        {
            _taskRepository = taskRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseTaskUpdatedJson> Execute(UpdateTaskStatusRequest request, long taskId)
        {
            var task = await _taskRepository.GetById(taskId) ?? throw new NotFoundException("Task not found");

            _taskRepository.UpdateStatus(task, request.Status);
            await _unitOfWork.Commit();

            return new ResponseTaskUpdatedJson
            {
                Title = task.Title,
                Status = task.Status,
                IsUpdateSucess = true
            };
        }
    }
}
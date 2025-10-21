using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Exceptions;
using GestaoDeProjetos.Api.Infra.Data.Repositories;

namespace GestaoDeProjetos.Api.UseCases.Tasks.Delete
{
    public class DeleteTaskUseCase
    {
        private readonly TaskRepository _taskRepository;
        private readonly UnitOfWork _unitOfWork;

        public DeleteTaskUseCase(TaskRepository taskRepository, UnitOfWork unitOfWork)
        {
            _taskRepository = taskRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(long taskId)
        {
            var task = await _taskRepository.GetById(taskId) ?? throw new NotFoundException("Task not found");

            _taskRepository.Delete(task);

            await _unitOfWork.Commit();

        }
    }
}
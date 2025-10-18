using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeProjetos.Api.Exceptions;
using GestaoDeProjetos.Api.Extensions;
using GestaoDeProjetos.Api.Infra.Data.Repositories;
using GestaoDeProjetos.Api.Requests;

namespace GestaoDeProjetos.Api.UseCases.Project.Create
{
    public class CreateProjectUseCase
    {

        private readonly ProjectRepository _productRepository;
        private readonly UnitOfWork _unitOfWork;

        public CreateProjectUseCase(ProjectRepository productRepository, UnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(CreateProjectRequestJson request)
        {
            Validate(request);
            var entity = request.ToEntity();

            await _productRepository.Create(entity);
            await _unitOfWork.Commit();
        }

        private static void Validate(CreateProjectRequestJson request)
        {
            var validator = new CreateProjectUseCaseValidator();
            var result = validator.Validate(request);

            if (result.IsValid.IsFalse())
            {
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).ToList());
            }
        }
    }
}